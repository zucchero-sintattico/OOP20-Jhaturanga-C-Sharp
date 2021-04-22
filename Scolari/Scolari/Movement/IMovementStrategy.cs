using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement
{
    public interface IMovementStrategy
    {
        ISet<IBoardPosition> GetPossibleMoves(IBoard board);
    }
}
