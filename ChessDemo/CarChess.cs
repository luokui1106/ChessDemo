using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 车类
    /// </summary>
    class CarChess:Chess
    {
        public CarChess() { }

        public CarChess(Type type, Camp camp, Point point) 
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

            //横向移动
            if (destY == y && destX != x)
            {
                //向右
                if (destX > x)
                {
                    for (int i = x + 1; i < destX; i++)
                    {
                        //判断中间有棋子挡住
                        if (GameControl.chessArray[y, i] != null)
                            return false;
                    }
                }
                //向左
                else
                {
                    for (int i = x - 1; i > destX; i--)
                    {
                        //判断中间有棋子挡住
                        if (GameControl.chessArray[y, i] != null)
                            return false;
                    }
                }
                return true;
            }
            //纵向移动
            if (destX == x && destY != y)
            {
                //向下
                if (destY > y)
                {
                    for (int i = y+1; i < destY; i++)
                    {
                        //判断中间有棋子挡住
                        if (GameControl.chessArray[i, x] != null)
                            return false;
                    }
                }
                //向上
                else
                {
                    for (int i = y-1; i > destY; i--)
                    {
                        //判断中间有棋子挡住
                        if(GameControl.chessArray[i,x]!=null)
                            return false;
                    }
                }
                return true;
            }
            return false;
        }
        #endregion
    }
}
