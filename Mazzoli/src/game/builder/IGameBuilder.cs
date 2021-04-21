using Mazzoli.game.controller;
using Mazzoli.game.movementmanager;
using Mazzoli.game.type;

namespace Mazzoli.game.builder
{
    public interface IGameBuilder
    {
        IGameBuilder GameType(GameType type);

        IGameBuilder GameController(IGameController gameController);

        IGameBuilder MovementManager(IMovementManager movementManager);

        IGame Build();
    }
}