using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Movement;

namespace Scolari.ChessProblem
{
    public interface IProblem
    {
        /// <summary>
        /// IList<IBasicMovement> - the sequence of moves the problem is made of
        /// </summary>
        IList<IBasicMovement> CorrectMoves { get; }

        /// <summary>
        /// returns the starting board representing a situation in medias-res of a match
        /// </summary>
        IBoard ProblemStartingBoard { get; }
    }
}
