using Mazzoli.game;
using Mazzoli.game.util;
using Mazzoli.player;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game.factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IStartingBoardFactory _startingBoardFactory = new StartingBoardFactory();

        private IGame AllClassicApartFromMovementStrategy(IPlayerPair players,
        IPieceMovementStrategies pieceMovementStrategy, GameType type) {
            IGameController gameController = new ClassicGameController(this._startingBoardFactory.ClassicBoard(players),
                pieceMovementStrategy, players);

            return IGame.Builder().GameType(type).GameController(gameController)
                .MovementManager(new ClassicMovementManager(gameController)).Build();
        }



        private IGame AllClassicDifferentBoard(IPlayerPair players, IBoard startingBoard, 
            GameType type) {
            IGameController gameController = new ClassicGameController(startingBoard,
                new ClassicNoCastlingPieceMovementStrategies(), players);

            return IGame.Builder().GameType(type).GameController(gameController)
                .MovementManager(new ClassicMovementManager(gameController)).Build();
        }
        
        public IGame Classic(IPlayerPair playerPair) =>
            this.AllClassicApartFromMovementStrategy(playerPair, new ClassicWithCastlingPieceMovementStrategies(),
                GameType.Classic);

        public IGame PawnHordeVariant(IPlayerPair playerPair) =>
            AllClassicDifferentBoard(playerPair, this._startingBoardFactory.PawnHordeBoard(playerPair),
                GameType.PawnHorde);
    }
}