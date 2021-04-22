using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board;

namespace Jhaturanga_CSharp.ChessProblem
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
