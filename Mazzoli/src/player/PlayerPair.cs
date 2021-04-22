using System.Collections.Generic;

namespace Mazzoli.player
{
    /// <summary>
    /// Implementation of the IPlayerPair interface.
    /// </summary>
    public class PlayerPair : IPlayerPair
    {
        public IPlayer WhitePlayer { get; }
        public IPlayer BlackPlayer { get; }

        public PlayerPair(IPlayer whitePlayer, IPlayer blackPlayer)
        {
            // Check that the whitePlayer is really a white Player and blackPlayer is really a Black Player.
            if (!whitePlayer.Color.Equals(PlayerColor.White))
            {
                throw new System.ArgumentException("White Player should be WHITE");
            }
            if (!blackPlayer.Color.Equals(PlayerColor.Black))
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