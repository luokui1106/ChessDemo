using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 马类 
    /// </summary>
    class HorseChess:Chess
    {
         public HorseChess() { }

         public HorseChess(Type type, Camp camp, Point point) 
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

             //向右
             if (destX == x + 2 && (destY == y - 1 || destY == y + 1))
             {
                 //判断不撇马脚
                 if (GameControl.chessArray[y, x+1] == null)
                     return true;
             }
             //向左
             if (destX == x - 2 && (destY == y - 1 || destY == y + 1))
             {
                 //判断不撇马脚
                 if (GameControl.chessArray[y , x-1] == null)
                     return true;
             }
             //向下
             if (destY == y + 2 && (destX == x - 1 || destX == x + 1))
             {
                 //判断不撇马脚
                 if (GameControl.chessArray[y+1 , x] == null)
                     return true;
             }
             //向上
             if (destY == y - 2 && (destX == x - 1 || destX == x + 1))
             {
                 //判断不撇马脚
                 if (GameControl.chessArray[y-1, x] == null)
                     return true;
             }
             return false;
        }
        #endregion
    }
}
