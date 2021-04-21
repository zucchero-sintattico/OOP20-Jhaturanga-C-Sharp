using System.Collections.Generic;

namespace Mazzoli.player
{
    /// <summary>
    /// The pair of players.
    /// Used to save the players which are playing.
    /// </summary>
    public interface IPlayerPair
    {
        /// <summary>
        /// The White Player.
        /// </summary>
        IPlayer WhitePlayer { get; }
        
        /// <summary>
        /// The Black Player
        /// </summary>
        IPlayer BlackPlayer { get; }
        
        /// <summary>
        /// An Enumerable of the two players [white, black]
        /// </summary>
        /// <returns></returns>
        IEnumerable<IPlayer> Enumerable();

    }
}