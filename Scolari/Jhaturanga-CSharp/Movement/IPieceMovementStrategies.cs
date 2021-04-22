using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement
{
    public interface IPieceMovementStrategies
    {
        IMovementStrategy PieceMovementStrategy(IPiece piece);
    }
}
