using Scolari.Pieces;

namespace Scolari.Movement
{
    public interface IPieceMovement : IBasicMovement 
    {
        /// <summary>
        /// the Piece involved
        /// </summary>
        IPiece PieceInvolved { get; }

        /// <summary>
        /// Executes the movement itself
        /// </summary>
        void Execute();


    }
}
