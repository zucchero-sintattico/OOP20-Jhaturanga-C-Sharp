using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.ChessProblem
{
    public interface IProblem
    {
        IList<IBasicMovement> CorrectMoves { get; }
        IBoard ProblemStartingBoard { get; }
    }
}
