using System.Collections.Generic;
interface IPlayerPair
{
    IPlayer WhitePlayer { get; }
    IPlayer BlackPlayer { get; }
    IEnumerable<IPlayer> Enumerable();

}