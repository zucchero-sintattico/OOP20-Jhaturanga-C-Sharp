using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.factory;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.test.Mazzoli.game
{
    public class GameFactoryTest
    {

        private readonly IGameFactory _gameFactory = new GameFactory();
        private IPlayerPair _players;

        [SetUp]
        public void SetUp()
        {
            this._players = new PlayerPair(new Player(new User("Alessandro", "", 0, 0, 0), PlayerColor.White),
                new Player(new User("Tommaso", "", 0, 0, 0), PlayerColor.Black));
        }
        
        [Test]
        public void Classic()
        {
            Assert.AreEqual(GameType.Classic, this._gameFactory.Classic(this._players).Type);
        }
        
        [Test]
        public void PawnHordeVariant()
        {
            Assert.AreEqual(GameType.PawnHorde, this._gameFactory.PawnHordeVariant(this._players).Type);
        }

        
    }
}