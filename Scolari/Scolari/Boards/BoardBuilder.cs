using System.Collections.Generic;
using Scolari.Pieces;

namespace Scolari.Boards
{
    public class BoardBuilder : IBoardBuilder
    {
        private int _rows;
        private int _columns;
        private readonly ISet<IPiece> _piecesOnBoard = new HashSet<IPiece>();

        public IBoardBuilder AddPiece(IPiece piece)
        {
            this._piecesOnBoard.Add(piece);
            return this;
        }

        public IBoardBuilder Columns(int columns)
        {
            this._columns = columns;
            return this;
        }

        public IBoardBuilder Rows(int rows)
        {
            this._rows = rows;
            return this;
        }

        public IBoard Build()
        {
            return new Board(this._piecesOnBoard, this._columns, this._rows);
        }

    }
}
