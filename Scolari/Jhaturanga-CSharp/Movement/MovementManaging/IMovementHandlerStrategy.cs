using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IMovementHandlerStrategy
    {
        bool IsMovementPossible(IPieceMovement movement);

        ISet<IBoardPosition> PossibleDestinations(IPiece piece);
    }
}
