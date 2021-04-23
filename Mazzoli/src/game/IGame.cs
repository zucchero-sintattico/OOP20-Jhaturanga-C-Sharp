using Mazzoli.game.builder;
using Mazzoli.game.type;
using Mazzoli.game.util;

namespace Mazzoli.game
{
    /// <summary>
    /// The interface of the Game entity.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// The Type of the game.
        /// </summary>
        GameType Type { get; }
        
        /// <summary>
        /// The Controller of the Game
        /// </summary>
        IGameController Controller { get; }
        
        /// <summary>
        /// The MovementManager of the Game
        /// </summary>
        IMovementManager MovementManager { get; }

        /// <summary>
        /// Get an instance of a GameBuilder
        /// </summary>
        /// <returns></returns>
        static IGameBuilder Builder()
        {
            return new GameBuilder();
        }
    }
}