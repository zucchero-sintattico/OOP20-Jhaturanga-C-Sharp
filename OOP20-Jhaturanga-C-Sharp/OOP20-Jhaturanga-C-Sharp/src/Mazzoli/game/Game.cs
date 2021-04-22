using Mazzoli.game.util;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game
{
    public class Game : IGame
    {
        public GameType Type { get; }

        public IGameController Controller { get; }

        public IMovementManager MovementManager { get; }

        public Game(GameType type, IGameController controller, IMovementManager movementManager)
        {
            this.Type = type;
            this.Controller = controller;
            this.MovementManager = movementManager;
        }
    }
}