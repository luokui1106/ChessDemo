using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDemo
{
    /// <summary>
    /// 士类
    /// </summary>
    class KnightChess:Chess
    {

        public KnightChess() { }

        public KnightChess(Type type, Camp camp, Point point) 
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

            //判断棋子移动的区域
            if (this.ChessCamp == Camp.红方 && (3 <= destX && destX <= 5) && (0 <= destY && destY <= 2) ||
                this.ChessCamp == Camp.黑方 && (3 <= destX && destX <= 5) && (7 <= destY && destY <= 9)
                )
            {
                //向上
                if ((destX == x - 1 && destY == y - 1) || (destX == x + 1 && destY == y - 1))
                {
                    return true;
                }
                //向下
                if ((destX == x - 1 && destY == y + 1) || (destX == x + 1 && destY == y + 1))
                {
                    return true;
                }
            }
            return false;

        }
        #endregion
    }
}
