using System.Collections.Generic;
using Scolari.Boards;

namespace Scolari.Movement
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
