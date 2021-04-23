using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Pieces;

namespace Scolari.Movement.MovementManaging
{
    public interface IMovementHandlerStrategy
    {
        /// <summary>
        /// Use this method to check if the passed movement is possible based on both the specific MovementStrategy and GameController
        /// </summary>
        /// <param name="movement">the movement to check if it's possible or not</param>
        /// <returns>true if the movement is possible, false otherwise</returns>
        bool IsMovementPossible(IPieceMovement movement);

        /// <summary>
        /// Get the passed Piece's possible BoardPositions where to move.
        /// </summary>
        /// <param name="piece">The piece of which to calculate the possible destinations</param>
        /// <returns>ISet<BoardPosition> representing the BoardPositions where the selected Piece can Move</returns>
        ISet<IBoardPosition> PossibleDestinations(IPiece piece);
    }
}
