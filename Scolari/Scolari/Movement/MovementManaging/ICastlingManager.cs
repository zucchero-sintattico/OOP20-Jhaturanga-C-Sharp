using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface ICastlingManager
    {
        /// <summary>
        /// Use this method to check whether the passed movement can be considered a castling movement
        /// </summary>
        /// <param name="movement">the movement onto check if it can considered a Castling</param>
        void CheckAndExecuteCastling(IPieceMovement movement);

        /// <summary>
        /// Use this method to check if the passed castling movement is correct
        /// </summary>
        /// <param name="movement">the movement to check if is a correct Castle</param>
        /// <returns>true if it's a correct castling</returns>
        bool IsCastlingFullyCorrect(IPieceMovement movement);

        /// <summary>
        /// Use this method to check if the passed movement is a possible castling
        /// </summary>
        /// <param name="movement">the movement to check if is a Castle</param>
        /// <returns>true if it's a Castle</returns>
        bool MightItBeCastle(IPieceMovement movement);
    }
}
