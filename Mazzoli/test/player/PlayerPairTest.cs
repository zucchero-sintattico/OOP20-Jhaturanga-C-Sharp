using System;
using Mazzoli.player;
using Mazzoli.player.util;
using NUnit.Framework;

namespace Mazzoli.test.player
{
    
    public class PlayerPairTest
    {
        private IUser _firstUser;
        private IUser _secondUser;
        
        [SetUp]
        public void Setup()
        {
            this._firstUser = new User("Alessandro");
            this._secondUser = new User("Manuel");
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