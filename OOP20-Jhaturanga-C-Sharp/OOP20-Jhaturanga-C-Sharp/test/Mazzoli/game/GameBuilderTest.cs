using Mazzoli.game.util;
using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.test.Mazzoli.game
{
    public class GameBuilderTest
    {

        private IPlayerPair _players;
        private IGameController _gameController;
        private IMovementManager _movementManager;
        private readonly IPieceMovementStrategies _pieceMovementStrategies = new ClassicWithCastlingPieceMovementStrategies();
        private readonly IStartingBoardFactory _startingBoardFactory = new StartingBoardFactory();

        [SetUp]
        public void SetUp()
        {
            this._players = new PlayerPair(new Player(new User("Alessandro", "", 0, 0,0), PlayerColor.White),
                new Player(new User("Tommaso", "", 0, 0, 0), PlayerColor.Black));

            this._gameController = new ClassicGameController(this._startingBoardFactory.ClassicBoard(this._players),
                this._pieceMovementStrategies, this._players);
            this._movementManager = new ClassicMovementManager(this._gameController);
        }
        
        [Test]
        public void NormalBuild()
        {
            var game = IGame.Builder().GameType(GameType.Classic).GameController(this._gameController)
                .MovementManager(this._movementManager).Build();
            Assert.AreEqual(GameType.Classic, game.Type);
        }
        
        [Test]
        public void MissingArgumentsBuild()
        {
            Assert.Throws<System.SystemException>(() => IGame.Builder().Build(), "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.Classic).Build(), "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.Classic).MovementManager(this._movementManager).Build()
                , "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.Classic).GameController(this._gameController).Build()
                , "All fields must be specified");
        }
        
        [Test]
        public void BuildTwice()
        {
            var builder = IGame.Builder();
            
            builder.GameType(GameType.Classic).GameController(this._gameController)
                .MovementManager(this._movementManager).Build();
            
            Assert.Throws<System.SystemException>(() => builder.Build(), "Already Built");
        }
        
        

        
    }
}