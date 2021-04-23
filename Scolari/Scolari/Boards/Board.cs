using System.Collections.Generic;
using Scolari.Pieces;
using System.Linq;

namespace Scolari.Boards
{
    public class Board : IBoard
    {
        public int Columns { get; }
        public int Rows { get; }

        private readonly IList<IPiece> _piecesOnBoard;

        public Board(ISet<IPiece> startingBoard, int columns, int rows)
        {
            this.Columns = columns;
            this.Rows = rows;
            this._piecesOnBoard = new List<IPiece>(startingBoard);
        }

        public bool Add(IPiece pieceToAdd)
        {
            if(this.GetPieceAtPosition(pieceToAdd.PiecePosition) == null)
            {
                this._piecesOnBoard.Add(pieceToAdd);
                return true;
            }
            return false;
        }

        public bool Contains(IBoardPosition positionToCheck)
        {
            return positionToCheck.X < this.Columns && positionToCheck.Y < this.Rows && positionToCheck.X >= 0 && positionToCheck.Y >= 0;
        }

        public bool Contains(IPiece pieceToCheck)
        {
            return this._piecesOnBoard.Contains(pieceToCheck);
        }

        public IPiece GetPieceAtPosition(IBoardPosition boardPosition)
        {
            return this._piecesOnBoard.FirstOrDefault(piece => piece.PiecePosition.Equals(boardPosition));
        }

        public ISet<IPiece> GetPieces()
        {
            return new HashSet<IPiece>(this._piecesOnBoard);
        }

        public bool Remove(IPiece pieceToRemove)
        {
            return this._piecesOnBoard.Remove(pieceToRemove);
        }

        public bool RemoveAtPosition(IBoardPosition positionToRemove)
        {
            return this.GetPieceAtPosition(positionToRemove) != null && this.Remove(this.GetPieceAtPosition(positionToRemove));
        }
    }
}
