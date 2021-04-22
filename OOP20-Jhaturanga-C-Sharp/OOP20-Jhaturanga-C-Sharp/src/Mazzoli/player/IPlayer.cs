using Mazzoli.player;
using Mazzoli.player.util;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.player
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