using Scolari.Boards;
using Scolari.Pieces;

namespace Scolari.Movement
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
