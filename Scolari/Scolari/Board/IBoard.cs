using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Board
{
    public interface IBoard
    {
        int Columns { get; }
        int Rows { get; }

        ISet<IPiece> getPieces();

        IPiece GetPieceAtPosition(IBoardPosition boardPosition);

        bool Contains(IBoardPosition positionToCheck);

        bool Contains(IPiece pieceToCheck);

        bool RemoveAtPosition(IBoardPosition positionToRemove);

        bool Remove(IPiece pieceToRemove);

        bool Add(IPiece pieceToAdd);

    }
}
