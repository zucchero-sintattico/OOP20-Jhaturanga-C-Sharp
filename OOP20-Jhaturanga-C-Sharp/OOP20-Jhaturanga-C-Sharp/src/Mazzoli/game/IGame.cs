using Mazzoli.game.util;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.builder;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game
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