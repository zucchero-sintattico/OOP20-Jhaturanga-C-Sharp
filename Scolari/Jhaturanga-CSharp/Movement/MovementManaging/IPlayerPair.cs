using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IPlayerPair
    {
        IPlayer WhitePlayer { get; }

        IPlayer BlackPlayer { get; }

        IEnumerable<IPlayer> Enumerable();
    }
}
