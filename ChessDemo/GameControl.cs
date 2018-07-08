using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 游戏控制类 静态类
    /// 一静态全静态  字段 属性 方法 全是静态的
    /// </summary>
    public static class GameControl
    {
        /// <summary>
        /// 二维数组 模拟每个棋子的位置 10行9列
        /// </summary>
        public static Chess[,] chessArray = new Chess[10, 9];

        /// <summary>
        /// 棋子宽度和高度
        /// </summary>
        public static int chessSize = 57;

        /// <summary>
        /// 棋盘
        /// </summary>
        public static Image img;

        #region 初始化棋子
        /// <summary>
        /// 初始化棋子
        /// </summary>
        public static void InitialChess()
        {
            //红方两个车
            CarChess redCarl = new CarChess(Type.車, Camp.红方, new Point(10, 10));
            CarChess redCar2 = new CarChess(Type.車, Camp.红方, new Point(10 + 8 * chessSize, 10));

            //黑方两个车
            CarChess blkCar1 = new CarChess(Type.車, Camp.黑方, new Point(10, 10 + 9 * chessSize));
            CarChess blkCar2 = new CarChess(Type.車, Camp.黑方, new Point(10 + 8 * chessSize, 10 + 9 * chessSize));

            //红方马
            HorseChess redHorse1 = new HorseChess(Type.馬, Camp.红方, new Point(10+1*chessSize, 10));
            HorseChess redHorse2 = new HorseChess(Type.馬, Camp.红方, new Point(10 + 7 * chessSize, 10));

            //黑方马
            HorseChess blkHorse1 = new HorseChess(Type.馬, Camp.黑方, new Point(10 + 1 * chessSize, 10 + 9 * chessSize));
            HorseChess blkHorse2 = new HorseChess(Type.馬, Camp.黑方, new Point(10 + 7 * chessSize, 10 + 9 * chessSize));

            //红方相
            ElephantChess redEle1 = new ElephantChess(Type.相, Camp.红方, new Point(10 + 2 * chessSize, 10));
            ElephantChess redEle2 = new ElephantChess(Type.相, Camp.红方, new Point(10 + 6 * chessSize, 10));

            //黑方象
            ElephantChess blkEle1 = new ElephantChess(Type.相, Camp.黑方, new Point(10 + 2 * chessSize, 10 + 9 * chessSize));
            ElephantChess blkEle2 = new ElephantChess(Type.相, Camp.黑方, new Point(10 + 6 * chessSize, 10 + 9 * chessSize));

            //红方仕
            KnightChess redKnig1 = new KnightChess(Type.士, Camp.红方, new Point(10 + 3 * chessSize, 10));
            KnightChess redKnig2 = new KnightChess(Type.士, Camp.红方, new Point(10 + 5 * chessSize, 10));

            //黑方士
            KnightChess blkKnig1 = new KnightChess(Type.士, Camp.黑方, new Point(10 + 3 * chessSize, 10 + 9 * chessSize));
            KnightChess blkKnig2 = new KnightChess(Type.士, Camp.黑方, new Point(10 + 5 * chessSize, 10 + 9 * chessSize));

            //红方帥
            GeneralChess redGen = new GeneralChess(Type.帥, Camp.红方, new Point(10 + 4 * chessSize, 10));

            //黑方将
            GeneralChess blkGen = new GeneralChess(Type.帥, Camp.黑方, new Point(10 + 4 * chessSize, 10 + 9 * chessSize));

            //红方炮
            ShellChess redShell1 = new ShellChess(Type.炮, Camp.红方, new Point(10 + 1 * chessSize, 10 + 2 * chessSize));
            ShellChess redShell2 = new ShellChess(Type.炮, Camp.红方, new Point(10 + 7 * chessSize, 10 + 2 * chessSize));

            //黑方炮
            ShellChess blkShell1 = new ShellChess(Type.炮, Camp.黑方, new Point(10 + 1 * chessSize, 10 + 7 * chessSize));
            ShellChess blkShell2 = new ShellChess(Type.炮, Camp.黑方, new Point(10 + 7 * chessSize, 10 + 7 * chessSize));

            //存储红方兵
            PawnChess[] redPawn=new PawnChess[5];
            //存储黑方卒
            PawnChess[] blkPawn = new PawnChess[5];

            for (int i = 0; i < 5; i++)
            {
                //红方兵
                redPawn[i] = new PawnChess(Type.兵, Camp.红方, new Point(10+(i*2)*chessSize, 10 + 3 * chessSize));
                //黑方卒
                blkPawn[i] = new PawnChess(Type.兵, Camp.黑方, new Point(10 + (i * 2) * chessSize, 10 + 6 * chessSize));
            }

          
            //装进数组
            chessArray[0, 0] = redCarl;
            chessArray[0, 8] = redCar2;

            chessArray[9, 0] = blkCar1;
            chessArray[9, 8] = blkCar2;

            chessArray[0, 1] = redHorse1;
            chessArray[0, 7] = redHorse2;

            chessArray[9, 1] = blkHorse1;
            chessArray[9, 7] = blkHorse2;

            chessArray[0, 2] = redEle1;
            chessArray[0, 6] = redEle2;

            chessArray[9, 2] = blkEle1;
            chessArray[9, 6] = blkEle2;

            chessArray[0, 3] = redKnig1;
            chessArray[0, 5] = redKnig2;

            chessArray[9, 3] = blkKnig1;
            chessArray[9, 5] = blkKnig2;

            chessArray[0, 4] = redGen;

            chessArray[9, 4] = blkGen;

            chessArray[2, 1] = redShell1;
            chessArray[2, 7] = redShell2;

            chessArray[7, 1] = blkShell1;
            chessArray[7, 7] = blkShell2;

            for (int i = 0; i < 5; i++)
            {
                chessArray[3, i * 2] = redPawn[i];
                chessArray[6, i * 2] = blkPawn[i];
            }

            DrawAllChess();

        }
        #endregion 

        #region 画棋子的方法
        /// <summary>
        /// 画棋子的方法
        /// </summary>
        public static void DrawAllChess()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(chessArray[i,j]!=null)
                    {
                        chessArray[i, j].DrawChess(img);
                    }
                }
            }
        }
        #endregion

        #region 判定输赢
        /// <summary>
        /// 判定输赢
        /// </summary>
        /// <param name="chess">被吃掉的棋子</param>
        /// <returns></returns>
        public static bool IsWin(Chess chess)
        {
            if (chess.ChessType == Type.帥)
            {
                //画出胜利的字
                Graphics g = Graphics.FromImage(img);
                string words = "";
                Brush brush;
                if (chess.ChessCamp == Camp.红方)
                {
                    words = "黑方胜利";
                    brush = new SolidBrush(Color.Black);
                }
                else
                {
                    words = "红方胜利";
                    brush = new SolidBrush(Color.Red);
                }
                Font font = new Font("楷体", 40, FontStyle.Bold);
                g.DrawString(words, font, brush, 145, 265);
                return true;
            }
            return false;
        }
        #endregion

        #region 清空棋盘数组
        /// <summary>
        /// 清空棋盘数组
        /// </summary>
        public static void ClearArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    chessArray[i, j] = null;
                }
            }
        }
        #endregion
    }
}
