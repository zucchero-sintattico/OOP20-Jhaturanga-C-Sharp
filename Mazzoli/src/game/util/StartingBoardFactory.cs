using Mazzoli.player;

namespace Mazzoli.game.util
{
    public class StartingBoardFactory : IStartingBoardFactory
    {
        public IBoard ClassicBoard(IPlayerPair players)
        {
            return null;
        }

        public IBoard PawnHordeBoard(object players)
        {
            return null;
        }
    }
}