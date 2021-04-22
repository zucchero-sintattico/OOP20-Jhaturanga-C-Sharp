using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp
{
    class PieceMovement : IPieceMovement
    {
        public IPiece PieceInvolved { get; }

        public IBoardPosition Origin { get; }

        public IBoardPosition Destination { get; }

        public PieceMovement(IPiece piece, IBoardPosition origin, IBoardPosition destination)
        {
            this.PieceInvolved = piece;
            this.Origin = origin;
            this.Destination = destination;
        }

        public PieceMovement(IPiece piece, IBoardPosition destination) : this(piece, piece.PiecePosition, destination) { }

        public void Execute()
        {
            this.PieceInvolved.PiecePosition = this.Destination;
            this.PieceInvolved.HasMoved = true;
        }
    }
}
