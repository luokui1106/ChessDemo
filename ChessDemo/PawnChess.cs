using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 兵类
    /// </summary>
    class PawnChess:Chess
    {
         public PawnChess() { }

         public PawnChess(Type type, Camp camp, Point point) 
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

             //红方
             if (this.ChessCamp == Camp.红方)
             {
                 //判断红方兵未过河时
                 if (destY <= 4)
                 {
                     //向下
                     if (destX == x && destY == y + 1)
                         return true;
                 }
                 //判断红方兵已经过河
                 else if (destY >= 5)
                 {
                     //向下
                     if (destX == x && destY == y + 1)
                         return true;
                     //左右
                     if ((destX == x - 1 && destY == y) || (destX == x + 1 && destY == y))
                         return true;
                 }
             }

             //黑方
             if (this.ChessCamp == Camp.黑方 )
             {
                 //判断黑方兵未过河
                 if (destY >= 5)
                 {
                     //向上
                     if (destX == x && destY == y - 1)
                         return true;
                 }
                 //判断黑方兵已经过河
                 else if (destY <= 4)
                 {
                     //向上
                     if (destX == x && destY == y - 1)
                         return true;
                     //左右
                     if ((destX == x - 1 && destY == y) || (destX == x + 1 && destY == y))
                         return true;
                 }
             }

             return false;
        }
        #endregion

    }
}
