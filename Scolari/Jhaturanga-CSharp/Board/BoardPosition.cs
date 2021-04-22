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

    }
}
