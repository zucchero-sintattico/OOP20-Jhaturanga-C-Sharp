using Jhaturanga_CSharp.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
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
