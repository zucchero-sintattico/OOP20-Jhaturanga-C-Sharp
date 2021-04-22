using Mazzoli.player;

namespace Mazzoli.game.util
{
    public interface IGameController
    {
        IPlayerPair Players { get; set; }
    }
}