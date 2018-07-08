using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 将 帥 类
    /// </summary>
    class GeneralChess:Chess
    {   
        public GeneralChess() { }

        public GeneralChess(Type type, Camp camp, Point point) 
        :base(type,camp,point){ }

        #region 移动方法
        /// <summary>
        /// 移动方法
        /// </summary>
        public override bool Move(int destX, int destY)
        {
            //destX destY新位置 
            //x y 原始位置

            //计算当前这个棋子在数组中的位置
            int x = (this.ChessPoint.X - 10) / 57;
            int y = (this.ChessPoint.Y - 10) / 57;

            //取出点击位置的棋子
            Chess chess = GameControl.chessArray[destY, destX];

            if (chess != null)
            {
                //取出点击位置的棋子的类型
                Type type = GameControl.chessArray[destY, destX].ChessType;

                //判断红方帥和黑方将相对的情况
                if (this.ChessCamp == Camp.红方 && type == Type.帥 && destX == x && 7 <= destY && destY <= 9)
                {
                    for (int i = y + 1; i < destY; i++)
                    {
                        //判断中间是否有棋子挡住
                        if (GameControl.chessArray[i, x] != null)
                            return false;
                    }
                    return true;
                }
                //判断黑方将和红方帥相对的情况
                else if (this.ChessCamp == Camp.黑方 && type == Type.帥 && destX == x && 0 <= destY && destY <= 3)
                {
                    for (int i = y - 1; i > destY; i--)
                    {
                        //判断中间是否有棋子挡住
                        if (GameControl.chessArray[i, x] != null)
                            return false;
                    }
                    return true;
                }
            }

            //判断棋子移动的范围
            if (this.ChessCamp == Camp.红方 && (3 <= destX && destX <= 5) && (0 <= destY && destY <= 2) ||
                this.ChessCamp == Camp.黑方 && (3 <= destX && destX <= 5) && (7 <= destY && destY <= 9)
                )
            {
                //上下
                if ((destX == x && destY == y - 1) || destX == x && destY == y + 1)
                    return true;
                //左右
                if ((destX == x - 1 && destY == y) || (destX == x + 1 && destY == y))
                    return true;
            }
            return false;
        }
        #endregion
    }
}
