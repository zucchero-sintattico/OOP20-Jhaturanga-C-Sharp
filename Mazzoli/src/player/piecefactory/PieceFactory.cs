namespace Mazzoli.player.piecefactory
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