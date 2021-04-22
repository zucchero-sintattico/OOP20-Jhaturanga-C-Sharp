using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Board
{
    class BoardBuilder : IBoardBuilder
    {
        private int rows;
        private int columns;
        private readonly ISet<IPiece> piecesOnBoard = new HashSet<IPiece>();

        public IBoardBuilder AddPiece(IPiece piece)
        {
            this.piecesOnBoard.Add(piece);
            return this;
        }

        public IBoardBuilder Columns(int columns)
        {
            this.columns = columns;
            return this;
        }

        public IBoardBuilder Rows(int rows)
        {
            this.rows = rows;
            return this;
        }

        public IBoard Build()
        {
            return new Board(this.piecesOnBoard, this.columns, this.rows);
        }

    }
}
