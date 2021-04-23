using Mazzoli.game.type;
using Mazzoli.game.util;

namespace Mazzoli.game.builder
{
    /// <summary>
    /// An IGame Builder.
    /// </summary>
    public interface IGameBuilder
    {
        /// <summary>
        /// Set the GameType of the game
        /// </summary>
        /// <param name="type">the GameType</param>
        /// <returns>this</returns>
        IGameBuilder GameType(GameType type);

        /// <summary>
        /// Set the GameController of the game.
        /// </summary>
        /// <param name="gameController">the GameController</param>
        /// <returns>this</returns>
        IGameBuilder GameController(IGameController gameController);

        /// <summary>
        /// Set the MovementManager of the game
        /// </summary>
        /// <param name="movementManager">the MovementManager</param>
        /// <returns>this</returns>
        IGameBuilder MovementManager(IMovementManager movementManager);

        /// <summary>
        /// Build the IGame
        /// </summary>
        /// <returns>the created IGame</returns>
        IGame Build();
    }
}