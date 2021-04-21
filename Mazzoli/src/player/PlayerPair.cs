using System.Collections.Generic;

namespace Mazzoli.player
{
    public class PlayerPair : IPlayerPair
    {
        public IPlayer WhitePlayer { get; }
        public IPlayer BlackPlayer { get; }

        public PlayerPair(IPlayer whitePlayer, IPlayer blackPlayer)
        {
            if (!whitePlayer.Color.Equals(PlayerColor.WHITE))
            {
                throw new System.ArgumentException("White Player should be WHITE");
            }
            if (!blackPlayer.Color.Equals(PlayerColor.BLACK))
            {
                throw new System.ArgumentException("Black Player should be BLACK");
            }
            this.WhitePlayer = whitePlayer;
            this.BlackPlayer = blackPlayer;
        }

        public IEnumerable<IPlayer> Enumerable()
        {
            return new List<IPlayer>() { this.WhitePlayer, this.BlackPlayer };
        }



    }
}