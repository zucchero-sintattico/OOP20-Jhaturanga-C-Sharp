using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IMovementManager
    {
        MovementResult Move(IPieceMovement movement);

        IPlayer PlayerTurn();

        ISet<IBoardPosition> FilterOnPossibleMovesBasedOnGameController(IPiece piece);
    }
}
