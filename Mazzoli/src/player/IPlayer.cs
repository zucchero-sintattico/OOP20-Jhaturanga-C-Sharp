using Mazzoli.player.util;

namespace Mazzoli.player
{
    /// <summary>
    /// The Player Entity.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The color of the player
        /// </summary>
        PlayerColor Color { get; }
        
        /// <summary>
        /// The User attached to this player;
        /// </summary>
        IUser User { get; }
        
        /// <summary>
        /// The PieceFactory of this player.
        /// </summary>
        IPieceFactory PieceFactory { get; }


    }
}