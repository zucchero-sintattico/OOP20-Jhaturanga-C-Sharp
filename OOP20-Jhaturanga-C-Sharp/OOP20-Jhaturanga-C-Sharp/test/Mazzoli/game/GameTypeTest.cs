using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.test.Mazzoli.game
{
    public class GameTypeTest
    {

        [Test]
        public void GetName()
        {
            Assert.AreEqual(GameType.Classic.GetName(), "Classic");
            Assert.AreEqual(GameType.PawnHorde.GetName(), "Pawn Horde Variant");
        }

        [Test]
        public void GetDescription()
        {
            Assert.AreEqual(GameType.Classic.GetDescription(), "The classic chess game");
            Assert.AreEqual(GameType.PawnHorde.GetDescription(), "The white player has an horde of pawns");
        }
        
        [Test]
        public void GetNewGameInstance()
        {
            IPlayerPair players = new PlayerPair(new Player(new User("Alessandro", "", 0, 0, 0), PlayerColor.White),
                new Player(new User("Stefano", "", 0, 0, 0), PlayerColor.Black));
            
            Assert.AreEqual(GameType.Classic.GetNewGameInstance(players).Type, GameType.Classic);
            Assert.AreEqual(GameType.PawnHorde.GetNewGameInstance(players).Type, GameType.PawnHorde);
        }
        
    }
}