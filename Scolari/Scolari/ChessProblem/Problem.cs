using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Movement;

namespace Scolari.ChessProblem
{
    public class Problem : IProblem
    {

        public IList<IBasicMovement> CorrectMoves { get; }
        public IBoard ProblemStartingBoard { get; }

        public Problem(IList<IBasicMovement> correctMoves, IBoard problemStartingBoard)
        {
            this.CorrectMoves = correctMoves;
            this.ProblemStartingBoard = problemStartingBoard;
        }

    }
}
