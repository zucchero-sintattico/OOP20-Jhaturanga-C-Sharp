using Mazzoli.player;
using Mazzoli.player.util;
using NUnit.Framework;

namespace Mazzoli.test
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