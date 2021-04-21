using Mazzoli.game.builder;
using Mazzoli.game.controller;
using Mazzoli.game.movementmanager;
using Mazzoli.game.type;

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