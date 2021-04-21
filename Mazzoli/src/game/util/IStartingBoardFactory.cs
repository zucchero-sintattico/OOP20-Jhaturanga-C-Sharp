using Mazzoli.player;

namespace Mazzoli.game.util
{
    public interface IStartingBoardFactory
    {
        IBoard ClassicBoard(IPlayerPair players);
        IBoard PawnHordeBoard(object players);
    }
}