using Mazzoli.player;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace Mazzoli.game.util
{
    public interface IStartingBoardFactory
    {
        IBoard ClassicBoard(IPlayerPair players);
        IBoard PawnHordeBoard(object players);
    }
}