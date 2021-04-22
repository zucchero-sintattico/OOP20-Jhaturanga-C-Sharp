using Mazzoli.player;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace Mazzoli.game.util
{
    public interface IGameController
    {
        IPlayerPair Players { get; set; }
    }
}