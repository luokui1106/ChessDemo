using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 象类 
    /// </summary>
    class ElephantChess:Chess
    {
         public ElephantChess() { }

         public ElephantChess(Type type, Camp camp, Point point) 
        :base(type,camp,point){ }

         #region 移动方法
         /// <summary>
        /// 实现父类移动方法
        /// </summary>
         public override bool Move(int destX, int destY)
        {

             //destX destY新位置 
             //x y 原始位置

             //计算当前这个棋子在数组中的位置
             int x = (this.ChessPoint.X - 10) / 57;
             int y = (this.ChessPoint.Y - 10) / 57;

             //判断只能在自己阵营移动
             if ((this.ChessCamp == Camp.红方 && destY <= 4) || (this.ChessCamp == Camp.黑方 && destY >= 5))
             {
                 //左上角
                 if (destX == x - 2 && destY == y - 2)
                 {
                     if (GameControl.chessArray[y - 1, x - 1] == null)
                         return true;
                 }
                 //右上角
                 if(destX == x + 2 && destY == y - 2)
                 {
                     if (GameControl.chessArray[y - 1, x + 1] == null)
                         return true;
                 }
                 //左下角
                 if (destX == x - 2 && destY == y + 2)
                 {
                     if (GameControl.chessArray[y + 1, x - 1] == null)
                         return true;

                 }
                 //右下角
                 if (destX == x + 2 && destY == y + 2)
                 {
                     if (GameControl.chessArray[y + 1, x + 1] == null)
                         return true;
                 }
                 return false;
             }
             return false;
        }
        #endregion
    }
}
