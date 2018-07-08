using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 炮类
    /// </summary>
    class ShellChess:Chess
    {
         public ShellChess() { }

         public ShellChess(Type type, Camp camp, Point point) 
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

             //获取点击位置的棋子
            Chess chess = GameControl.chessArray[destY, destX];

            int count = -1;

            //横向移动
            if (destY == y && destX != x)
            {
                //向右
                if (destX > x)
                {
                    count = 0;
                    for (int i = x + 1; i < destX; i++)
                    {
                        if (GameControl.chessArray[y, i] != null)
                            count++;
                    }
                }
                //向左
                else
                {
                    count = 0;
                    for (int i = x - 1; i > destX; i--)
                    {
                        if (GameControl.chessArray[y, i] != null)
                            count++;
                    }
                }
            }
            //纵向移动
            if (destX == x && destY != y)
            {
                //向下
                if (destY > y)
                {
                    count = 0;
                    for (int i = y + 1; i < destY; i++)
                    {
                        if (GameControl.chessArray[i, x] != null)
                            count++;
                    }
                }
                //向上
                else
                {
                    count = 0;
                    for (int i = y - 1; i > destY; i--)
                    {
                        if (GameControl.chessArray[i, x] != null)
                            count++;
                    }
                }
            }

            //点击位置有棋子(吃子) 并且中间只隔了一个棋
            if (count == 1 && chess != null)
                return true;
            //点击位置没有棋子(走棋) 
            if (count == 0 && chess == null)
                return true;

            return false;
        }
        #endregion
    }
}
