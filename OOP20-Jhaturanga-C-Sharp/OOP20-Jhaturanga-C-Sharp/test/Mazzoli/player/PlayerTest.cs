using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.test.Mazzoli.player
{
    
    public class PlayerTest
    {
        private IUser _user;
        
        [SetUp]
        public void Setup()
        {
            this._user = new User("Alessandro", "", 0, 0, 0);
        }

        [Test]
        public void ColorTest()
        {
            IPlayer player = new Player(this._user, PlayerColor.White);
            Assert.AreEqual(player.Color, PlayerColor.White);
            Assert.AreNotEqual(player.Color, PlayerColor.Black);
        }

        [Test]
        public void UserTest()
        {
            IPlayer player = new Player(this._user, PlayerColor.White);
            Assert.AreEqual(player.User, this._user);
        }
        
    }
}