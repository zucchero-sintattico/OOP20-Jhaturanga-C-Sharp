using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Board
{
    public class BoardPosition : IBoardPosition
    {
        public int X { get; }

        public int Y { get; }

        public BoardPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public BoardPosition(IBoardPosition pos) : this(pos.X, pos.Y) { }


        public override bool Equals(object obj)
        {
            return obj is BoardPosition position &&
                   X == position.X &&
                   Y == position.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
