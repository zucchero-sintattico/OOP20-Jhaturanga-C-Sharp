using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.test.Mazzoli.player
{
    
    public class PlayerPairTest
    {
        private IUser _firstUser;
        private IUser _secondUser;
        
        [SetUp]
        public void Setup()
        {
            this._firstUser = new User("Alessandro", "", 0, 0, 0);
            this._secondUser = new User("Manuel", "", 0, 0, 0);
        }

        [Test]
        public void RightColorTest()
        {
            IPlayer whitePlayer = new Player(this._firstUser, PlayerColor.White);
            IPlayer blackPlayer = new Player(this._secondUser, PlayerColor.Black);
            Assert.Throws<System.ArgumentException>(() =>
            {
                IPlayerPair playerPair = new PlayerPair(blackPlayer, whitePlayer);
            });
        }

        
    }
}