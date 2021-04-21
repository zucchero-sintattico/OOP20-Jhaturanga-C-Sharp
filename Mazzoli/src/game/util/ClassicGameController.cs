using Mazzoli.player;

namespace Mazzoli.game.util
{
    public class ClassicGameController : IGameController
    {
        private readonly IBoard _classicBoard;
        private readonly IPieceMovementStrategies _pieceMovementStrategy;
        private readonly IPlayerPair _players;
        public IPlayerPair Players { get; set; }
        
        public ClassicGameController(IBoard classicBoard, IPieceMovementStrategies pieceMovementStrategy, IPlayerPair players)
        {
            _classicBoard = classicBoard;
            _pieceMovementStrategy = pieceMovementStrategy;
            _players = players;
        }

    }
}