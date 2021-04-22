using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace Mazzoli.player.util
{
    public class PieceFactory : IPieceFactory
    {
        private IPlayer _player;

        public PieceFactory(IPlayer player)
        {
            this._player = player;
        }
    }
}