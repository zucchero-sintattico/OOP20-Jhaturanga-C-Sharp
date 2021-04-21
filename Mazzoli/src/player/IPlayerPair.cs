using System.Collections.Generic;

namespace Mazzoli.player
{
    public interface IPlayerPair
    {
        IPlayer WhitePlayer { get; }
        IPlayer BlackPlayer { get; }
        IEnumerable<IPlayer> Enumerable();

    }
}