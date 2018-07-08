using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 阵营
    /// </summary>
    public enum Camp
    {
        红方,黑方
    }
    /// <summary>
    /// 棋子类型
    /// </summary>
    public enum Type
    {
        車, 馬, 相, 士, 帥,炮,兵
    }
    /// <summary>
    /// 棋子类 父类
    /// </summary>
    public abstract class Chess
    {
        /// <summary>
        /// 阵营
        /// </summary>
        public Camp ChessCamp { get; set; }
        /// <summary>
        /// 棋子类型
        /// </summary>
        public Type ChessType { get; set; }
        /// <summary>
        /// 棋子的坐标
        /// </summary>
        public Point ChessPoint { get; set; }
        /// <summary>
        /// 棋子的背景图
        /// </summary>
        public Image ChessImage { get; set; }

        #region 构造函数

        public Chess() 
        {
            ChessImage = Image.FromFile(@"pic\棋子.png");
        }

        public Chess(Type type,Camp camp,Point point) 
        {
            ChessImage = Image.FromFile(@"pic\棋子.png");
            this.ChessType = type;
            this.ChessCamp = camp;
            this.ChessPoint = point;   
        }
        #endregion

        /// <summary>
        /// 抽象移动方法
        /// </summary>
        /// <param name="destX">移动的X位置</param>
        /// <param name="destY">移动的Y位置</param>
        /// <returns>能不能移动</returns>
        public abstract bool Move(int destX,int destY);

        #region 选子
        /// <summary>
        /// 选子  棋子四周画一个蓝色的框
        /// </summary>
        /// <param name="img">棋盘</param>
        public void Choice(Image img)
        {
            Graphics g = Graphics.FromImage(img);
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, this.ChessPoint.X - 2, this.ChessPoint.Y - 2, 54, 54);
        }
        #endregion

        #region 摆子
        /// <summary>
        /// 摆子  把棋子一个一个画棋盘上
        /// </summary>
        /// <param name="img">棋盘</param>
        public void DrawChess(Image img)
        {
            //1.画背景图
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(this.ChessImage, this.ChessPoint);

            //2.画文字
            string words = GetChessWords();
            Font font=new Font("楷体",22,FontStyle.Bold);
            Brush brush;
            if (this.ChessCamp == Camp.红方)
            {
                //new 红刷子
                brush = new SolidBrush(Color.Red);
            }
            else
            {
                //new 黑刷子
                brush = new SolidBrush(Color.Black);
            }
            g.DrawString(words,font,brush,this.ChessPoint.X+5,ChessPoint.Y+10);
        }
        #endregion

        #region 根据棋子的阵营返回棋子显示的文字
        /// <summary>
        /// 根据棋子的阵营返回棋子显示的文字
        /// </summary>
        /// <returns>返回棋子文字</returns>
        public string GetChessWords()
        {
            string str = "";
            if (this.ChessCamp == Camp.红方)
            {
                //红方繁体字
                switch (this.ChessType)
                {
                    case Type.車:
                        str = "車";
                        break;
                    case Type.馬:
                        str = "馬";
                        break;
                    case Type.相:
                        str = "相";
                        break;
                    case Type.士:
                        str = "仕";
                        break;
                    case Type.帥:
                        str = "帥";
                        break;
                    case Type.炮:
                        str = "炮";
                        break;
                    case Type.兵:
                        str = "兵";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                //黑方简体字
                switch (this.ChessType)
                {
                    
                    case Type.車:
                        str = "车";
                        break;
                    case Type.馬:
                        str = "马";
                        break;
                    case Type.相:
                        str = "象";
                        break;
                    case Type.士:
                        str = "士";
                        break;
                    case Type.帥:
                        str = "将";
                        break;
                    case Type.炮:
                        str = "炮";
                        break;
                    case Type.兵:
                        str = "卒";
                        break;
                    default:
                        break;
                }
            }
            return str;
        }
        #endregion
    }
}
