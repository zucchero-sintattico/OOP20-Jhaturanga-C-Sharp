using System.Collections.Generic;

namespace Scolari.Util
{
    public interface IPlayerPair
    {
        /// <summary>
        /// Returns the white player
        /// </summary>
        IPlayer WhitePlayer { get; }

        /// <summary>
        /// Returns the black player
        /// </summary>
        IPlayer BlackPlayer { get; }

        /// <summary>
        /// Returns a stream of the two players
        /// </summary>
        /// <returns></returns>
        IEnumerable<IPlayer> Enumerable();
    }
}
