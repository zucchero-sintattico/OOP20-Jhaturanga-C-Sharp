using Mazzoli.game;
using Mazzoli.game.util;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game.builder
{
    public interface IGameBuilder
    {
        IGameBuilder GameType(GameType type);

        IGameBuilder GameController(IGameController gameController);

        IGameBuilder MovementManager(IMovementManager movementManager);

        IGame Build();
    }
}