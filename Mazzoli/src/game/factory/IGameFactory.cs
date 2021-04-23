using Mazzoli.game;
using Mazzoli.player;

namespace Mazzoli.game.factory
{
    /// <summary>
    /// The Game Factory
    /// </summary>
    public interface IGameFactory
    {
        /// <summary>
        /// Get an instance of the classic chess game.
        /// </summary>
        /// <param name="playerPair">the players</param>
        /// <returns>the created game</returns>
        IGame Classic(IPlayerPair playerPair);

        /// <summary>
        /// Get an instance of the pawn horde chess variant.
        /// </summary>
        /// <param name="playerPair">the players</param>
        /// <returns>the created game</returns>
        IGame PawnHordeVariant(IPlayerPair playerPair);
    }
}