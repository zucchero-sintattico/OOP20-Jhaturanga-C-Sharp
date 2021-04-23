using System.Collections.Generic;
using Mazzoli.game;
using Mazzoli.game.builder;
using Mazzoli.game.factory;
using Mazzoli.game.type;
using Mazzoli.game.util;
using Mazzoli.player;
using Mazzoli.player.util;
using NUnit.Framework;

namespace Mazzoli.test.game
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
            this._players = new PlayerPair(new Player(new User("Alessandro"), PlayerColor.WHITE),
                new Player(new User("Tommaso"), PlayerColor.BLACK));

            this._gameController = new ClassicGameController(this._startingBoardFactory.ClassicBoard(this._players),
                this._pieceMovementStrategies, this._players);
            this._movementManager = new ClassicMovementManager(this._gameController);
        }
        
        [Test]
        public void NormalBuild()
        {
            var game = IGame.Builder().GameType(GameType.CLASSIC).GameController(this._gameController)
                .MovementManager(this._movementManager).Build();
            Assert.AreEqual(GameType.CLASSIC, game.Type);
        }
        
        [Test]
        public void MissingArgumentsBuild()
        {
            Assert.Throws<System.SystemException>(() => IGame.Builder().Build(), "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.CLASSIC).Build(), "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.CLASSIC).MovementManager(this._movementManager).Build()
                , "All fields must be specified");
            
            Assert.Throws<System.SystemException>(() => IGame.Builder().GameType(GameType.CLASSIC).GameController(this._gameController).Build()
                , "All fields must be specified");
        }
        
        [Test]
        public void BuildTwice()
        {
            var builder = IGame.Builder();
            
            builder.GameType(GameType.CLASSIC).GameController(this._gameController)
                .MovementManager(this._movementManager).Build();
            
            Assert.Throws<System.SystemException>(() => builder.Build(), "Already Built");
        }
        
        

        
    }
}