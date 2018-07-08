using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessDemo
{
    public partial class FrmChess : Form
    {
        public FrmChess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 表示游戏是否开始
        /// </summary>
        bool isBegin = false;

        /// <summary>
        /// 表示当前选择的棋子 篮框棋子
        /// </summary>
        Chess currentChess = null;

        /// <summary>
        ///表示该谁走棋 红方1 黑方0
        /// </summary>
        int isTurn = 1;

        #region 开始游戏
        //开始游戏
        private void tsmStrat_Click(object sender, EventArgs e)
        {
            if (isBegin)
            {
                MessageBox.Show("游戏已开始！", "友情提示");
                return;
            }

            GameControl.img = this.pbChessboard.Image;

            GameControl.InitialChess();

            this.pbChessboard.Image = GameControl.img;

            Frush();

            //表示游戏开始
            isBegin = true;
        }
        #endregion

        #region 重新开始
        //重新开始
        private void tsmRestart_Click(object sender, EventArgs e)
        {
            if (!isBegin)
            {
                MessageBox.Show("游戏未开始！","友情提示：");
                return;
            }

            GameControl.ClearArrays();

            GameControl.img = Image.FromFile(@"pic\棋盘.png");
            GameControl.InitialChess();
            pbChessboard.Image = GameControl.img;
        }
        #endregion

        //退出
        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 鼠标点击事件
        //鼠标点击事件
        private void pbChessboard_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isBegin)
            {
                return;
            }
            //取出点击位置的棋子

            //由坐标转换为下标
            int x = (e.X - 10) / GameControl.chessSize;
            int y = (e.Y - 10) / GameControl.chessSize;
            //MessageBox.Show("x:"+x+"y:"+y);
            Chess chess = GameControl.chessArray[y, x];
            //表示点击位置有棋子
            if (chess != null)
            {
                //没有篮框棋子
                if (currentChess == null)
                {
                    //选子
                    //如果该红方走 并且选的子就是红方
                    if (isTurn == 1 && chess.ChessCamp == Camp.红方)
                    {
                        //1、把点击这个棋子赋值给篮框棋子
                        currentChess = chess;
                        //2、画框
                        currentChess.Choice(GameControl.img);
                    }
                    //如果该黑方走 并且选的子就是黑方
                    else if(isTurn==0&&chess.ChessCamp==Camp.黑方)
                    {
                        //1、把点击这个棋子赋值给篮框棋子
                        currentChess = chess;
                        //2、画框
                        currentChess.Choice(GameControl.img);
                    }
                    Music.play("选子");
                }
                //有篮框棋子
                else
                {
                    //换子  吃子
                    //篮框棋子阵营等于选择(点击)棋子阵营
                    if (currentChess.ChessCamp == chess.ChessCamp)
                    {
                        //选子
                        //1、先抹掉篮框的棋子 就是重新画阵营
                        Frush();
                        //2、在新位置重写画一个篮框
                        currentChess = chess;
                        currentChess.Choice(GameControl.img);
                        Music.play("换子");
                    }
                    else
                    {
                        //x y点击位置的下标
                        if (!currentChess.Move(x, y))
                        {
                            return;
                        }
                        
                        //计算篮框棋子在原来数组中的下标位置
                        int xLan = (currentChess.ChessPoint.X - 10) / GameControl.chessSize;
                        int yLan = (currentChess.ChessPoint.Y - 10) / GameControl.chessSize;
                        
                        //吃子
                        //1、改变篮框棋子的坐标位置 
                        currentChess.ChessPoint = chess.ChessPoint;
                        //2、改变篮框棋子的数组中的位置也要改变
                        GameControl.chessArray[y, x] = currentChess;
                        //3、篮框棋子在数组中原来的位置恢复为null
                        GameControl.chessArray[yLan, xLan] = null;

                        //刷新
                        Frush();

                        //判断吃掉的棋子是不是boss
                        if (GameControl.IsWin(chess))
                        {
                            MessageBox.Show("游戏结束！");
                            isBegin = false;
                            GameControl.ClearArrays();
                            return;
                        }
                        else
                        {
                            //换人
                            TurnNext();
                        }
                        Music.play("吃子");
                    }
                }
            }
            //表示点击位置没有棋子 (走棋)
            else
            {
                if (currentChess == null)   //篮框棋子为空
                {
                    return;
                }
                else if (!currentChess.Move(x, y))
                {
                    return;
                }
                else
                {
                    //有篮框 又可以动

                    //计算篮框棋子在原来数组中的下标位置
                    int xLan = (currentChess.ChessPoint.X - 10) / GameControl.chessSize;
                    int yLan = (currentChess.ChessPoint.Y - 10) / GameControl.chessSize;
                        
                    //移动
                    //1、让篮框棋子移动到指定的位置 该坐标
                    int xDianJi = 10 + x * 57;
                    int yDianJi = 10 + y * 57;
                    currentChess.ChessPoint = new Point(xDianJi, yDianJi);
                    //2、改变篮框棋子在数组中的位置
                    GameControl.chessArray[y, x] = currentChess;
                    //3、篮框棋子在数组中的原来位置改为null
                    GameControl.chessArray[yLan, xLan] = null;

                    //刷新
                    Frush();
                    //换人
                    TurnNext();

                    Music.play("移动");
                }
                
            }

            this.pbChessboard.Image = GameControl.img;
        }
        #endregion

        #region 刷新棋盘
        /// <summary>
        /// 刷新棋盘
        /// </summary>
        public void Frush()
        {
            GameControl.img = Image.FromFile(@"pic\棋盘.png");
            GameControl.DrawAllChess();
            pbChessboard.Image = GameControl.img;
        }
        #endregion

        #region 换人方法
        /// <summary>
        /// 换人方法
        /// </summary>
        public void TurnNext()
        {
            if (isTurn == 0)
                isTurn = 1;
            else
                isTurn = 0;
            //把篮框棋子换成空
            currentChess = null;
        }
        #endregion

        #region 背景音乐

        //笑傲江湖
        private void tsmXiaoAo_Click(object sender, EventArgs e)
        {
            Music.PlaySong(@"sound\笑傲江湖.mp3");
        }

        //倩女幽魂
        private void tsmQianNv_Click(object sender, EventArgs e)
        {
            
            Music.PlaySong(@"sound\bgMusic.mid");
        }
        #endregion
    }
}
