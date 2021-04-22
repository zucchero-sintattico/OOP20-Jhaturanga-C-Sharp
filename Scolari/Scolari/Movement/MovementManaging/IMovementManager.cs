using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IMovementManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="movement">movement is the move to be executed on the Board</param>
        /// <returns>ActionType representing the type of action resulted from the action performed</returns>
        MovementResult Move(IPieceMovement movement);

        /// <summary>
        /// Used to get the Player who's turn it is.
        /// </summary>
        /// <returns>the Player who's turn it is</returns>
        IPlayer PlayerTurn();

        /// <summary>
        /// Get the passed Piece's possible BoardPositions where to move.
        /// </summary>
        /// <param name="piece">The piece of which calculate the possible moves</param>
        /// <returns>Set<BoardPosition> representing the BoardPositions where the selected Piece can Move</returns>
        ISet<IBoardPosition> FilterOnPossibleMovesBasedOnGameController(IPiece piece);
    }
}
