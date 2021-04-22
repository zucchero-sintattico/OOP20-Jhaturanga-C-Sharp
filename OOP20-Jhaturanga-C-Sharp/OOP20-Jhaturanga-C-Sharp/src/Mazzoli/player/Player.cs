using Mazzoli.player;
using Mazzoli.player.util;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.player
{
    /// <summary>
    /// Implementation of the IPlayer interface.
    /// </summary>
    public class Player : IPlayer
    {   
        
        public PlayerColor Color { get; }
        public IUser User { get; }
        public IPieceFactory PieceFactory { get; }

        public Player(IUser user, PlayerColor color)
        {
            this.User = user;
            this.Color = color;
            this.PieceFactory = new PieceFactory(this);
        }
        
        public override string ToString()
        {
            return "PlayerImpl [color=" + this.Color + ", user=" + this.User + "]";
        }
    }
}