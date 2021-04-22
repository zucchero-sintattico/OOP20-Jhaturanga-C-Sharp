using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement
{
    public interface IMovementStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="board">the actual board to check where the piece can go</param>
        /// <returns>a set of all possible position where the piece can go</returns>
        ISet<IBoardPosition> GetPossibleMoves(IBoard board);
    }
}
