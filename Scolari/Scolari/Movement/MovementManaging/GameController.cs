using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public class GameController : IGameController
    {
        public IBoard GetBoard()
        {
            throw new NotImplementedException();
        }

        public GameStatus getGameStatus(IPlayer playerTurn)
        {
            throw new NotImplementedException();
        }

        public IPieceMovementStrategies GetPieceMovementStrategies()
        {
            throw new NotImplementedException();
        }

        public IPlayerPair GetPlayers()
        {
            throw new NotImplementedException();
        }

        public bool IsInCheck(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public bool IsWinner(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public bool WouldNotBeInCheck(IPieceMovement movement)
        {
            throw new NotImplementedException();
        }
    }
}
