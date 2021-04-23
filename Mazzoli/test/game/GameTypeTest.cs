using Mazzoli.game;
using Mazzoli.game.type;
using Mazzoli.player;
using Mazzoli.player.util;
using NUnit.Framework;

namespace Mazzoli.test.game
{
    public class GameTypeTest
    {

        [Test]
        public void GetName()
        {
            Assert.AreEqual(GameType.CLASSIC.GetName(), "Classic");
            Assert.AreEqual(GameType.PAWN_HORDE.GetName(), "Pawn Horde Variant");
        }

        [Test]
        public void GetDescription()
        {
            Assert.AreEqual(GameType.CLASSIC.GetDescription(), "The classic chess game");
            Assert.AreEqual(GameType.PAWN_HORDE.GetDescription(), "The white player has an horde of pawns");
        }
        
        [Test]
        public void GetNewGameInstance()
        {
            IPlayerPair players = new PlayerPair(new Player(new User("Alessandro"), PlayerColor.WHITE),
                new Player(new User("Stefano"), PlayerColor.BLACK));
            
            Assert.AreEqual(GameType.CLASSIC.GetNewGameInstance(players).Type, GameType.CLASSIC);
            Assert.AreEqual(GameType.PAWN_HORDE.GetNewGameInstance(players).Type, GameType.PAWN_HORDE);
        }
        
    }
}