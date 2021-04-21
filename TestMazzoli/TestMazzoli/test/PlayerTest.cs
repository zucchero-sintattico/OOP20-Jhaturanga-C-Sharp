using Mazzoli.player;
using Mazzoli.player.user;
using NUnit.Framework;

namespace TestMazzoli.test
{
    
    public class PlayerTest
    {
        private IUser _user;
        
        [SetUp]
        public void Setup()
        {
            this._user = new User("Alessandro");
        }

        [Test]
        public void ColorTest()
        {
            IPlayer player = new Player(this._user, PlayerColor.WHITE);
            Assert.AreEqual(player.Color, PlayerColor.WHITE);
            Assert.AreNotEqual(player.Color, PlayerColor.BLACK);
        }

        [Test]
        public void UserTest()
        {
            IPlayer player = new Player(this._user, PlayerColor.WHITE);
            Assert.AreEqual(player.User, this._user);
        }
        
    }
}