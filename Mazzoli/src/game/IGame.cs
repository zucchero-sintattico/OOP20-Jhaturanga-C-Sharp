using Mazzoli.game.builder;
using Mazzoli.game.type;
using Mazzoli.game.util;

namespace Mazzoli.game
{
    public interface IGame
    {
        GameType Type { get; }
        IGameController Controller { get; }
        IMovementManager MovementManager { get; }

        static IGameBuilder Builder()
        {
            return new GameBuilder();
        }
    }
}