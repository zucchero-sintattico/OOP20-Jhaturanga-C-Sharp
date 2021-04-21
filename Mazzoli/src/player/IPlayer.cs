using Mazzoli.player.piecefactory;
using Mazzoli.player.user;

namespace Mazzoli.player
{
    public interface IPlayer
    {
        PlayerColor Color { get; }
        IUser User { get; }
        IPieceFactory PieceFactory { get; }


    }
}