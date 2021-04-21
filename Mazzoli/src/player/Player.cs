using Mazzoli.player.piecefactory;
using Mazzoli.player.user;

namespace Mazzoli.player
{
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