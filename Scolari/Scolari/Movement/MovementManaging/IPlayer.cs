using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IPlayer
    {
        PlayerColor Color { get; }

        IUser User { get; }

        IPieceFactory PieceFactory { get; }
    }
}
