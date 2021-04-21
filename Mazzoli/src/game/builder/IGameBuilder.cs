using Mazzoli.game.type;
using Mazzoli.game.util;

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