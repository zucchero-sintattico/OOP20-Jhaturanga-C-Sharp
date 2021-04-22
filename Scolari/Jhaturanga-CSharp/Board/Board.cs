using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Board
{
    class Board : IBoard
    {
        public int Columns { get; }

        public int Rows { get; }

        private readonly IList<IPiece> piecesOnBoard = new List<IPiece>();

        public Board(ISet<IPiece> startingBoard, int columns, int rows)
        {
            this.Columns = columns;
            this.Rows = rows;
            this.piecesOnBoard = new List<IPiece>(startingBoard);
        }

        public bool Add(IPiece pieceToAdd)
        {
            if(this.GetPieceAtPosition(pieceToAdd.PiecePosition) == null)
            {
                this.piecesOnBoard.Add(pieceToAdd);
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
            return this.piecesOnBoard.Contains(pieceToCheck);
        }

        public IPiece GetPieceAtPosition(IBoardPosition boardPosition)
        {
            foreach(IPiece piece in this.piecesOnBoard)
            {
                if(piece.PiecePosition.Equals(boardPosition))
                {
                    return piece;
                }
            }
            return null;
        }

        public ISet<IPiece> getPieces()
        {
            return new HashSet<IPiece>(this.piecesOnBoard);
        }

        public bool Remove(IPiece pieceToRemove)
        {
            return this.piecesOnBoard.Remove(pieceToRemove);
        }

        public bool RemoveAtPosition(IBoardPosition positionToRemove)
        {
            if(this.GetPieceAtPosition(positionToRemove) != null)
            {
                return this.Remove(this.GetPieceAtPosition(positionToRemove));
            }
            return false;
        }
    }
}
