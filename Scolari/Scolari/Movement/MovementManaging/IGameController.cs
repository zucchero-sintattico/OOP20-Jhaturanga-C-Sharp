using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IGameController
    {

        GameStatus getGameStatus(IPlayer playerTurn);

        bool IsInCheck(IPlayer player);

        bool WouldNotBeInCheck(IPieceMovement movement);

        bool IsWinner(IPlayer player);

        IBoard GetBoard();

        IPlayerPair GetPlayers();

        IPieceMovementStrategies GetPieceMovementStrategies();
    }
}
