using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IPlayer
    {
        /// <summary>
        /// Get the color of this player.
        /// </summary>
        PlayerColor Color { get; }
        /// <summary>
        /// Get the User of the player.
        /// </summary>
        IUser User { get; }
        /// <summary>
        /// Used to get the Player's PieceFactory.
        /// </summary>
        IPieceFactory PieceFactory { get; }
    }
}
