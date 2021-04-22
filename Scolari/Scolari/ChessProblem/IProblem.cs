using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.ChessProblem
{
    public interface IProblem
    {
        /// <summary>
        /// 
        /// </summary>
        IList<IBasicMovement> CorrectMoves { get; }
        /// <summary>
        /// 
        /// </summary>
        IBoard ProblemStartingBoard { get; }
    }
}
