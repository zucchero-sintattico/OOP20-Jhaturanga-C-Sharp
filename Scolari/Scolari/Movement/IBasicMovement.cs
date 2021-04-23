using Scolari.Boards;

namespace Scolari.Movement
{
    public interface IBasicMovement
    {
        /// <summary>
        /// the position of the wanted destination for the Piece
        /// </summary>
        IBoardPosition Origin { get; }

        /// <summary>
        /// the position of the starting position of the Piece in this movement
        /// </summary>
        IBoardPosition Destination { get; }

    }
}
