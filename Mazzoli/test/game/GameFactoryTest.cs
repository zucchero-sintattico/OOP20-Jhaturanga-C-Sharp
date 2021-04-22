using Mazzoli.game;
using Mazzoli.game.factory;
using Mazzoli.game.type;
using Mazzoli.player;
using Mazzoli.player.util;
using NUnit.Framework;

namespace Mazzoli.test.game
{
    public class GameFactoryTest
    {

        private readonly IGameFactory _gameFactory = new GameFactory();
        private IPlayerPair _players;

        [SetUp]
        public void SetUp()
        {
            this._players = new PlayerPair(new Player(new User("Alessandro"), PlayerColor.White),
                new Player(new User("Tommaso"), PlayerColor.Black));
        }
        
        [Test]
        public void Classic()
        {
            Assert.AreEqual(GameType.CLASSIC, this._gameFactory.Classic(this._players).Type);
        }
        
        [Test]
        public void PawnHordeVariant()
        {
            Assert.AreEqual(GameType.PAWN_HORDE, this._gameFactory.PawnHordeVariant(this._players).Type);
        }

        
    }
}