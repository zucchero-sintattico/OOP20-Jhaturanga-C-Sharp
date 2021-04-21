using System;
using Mazzoli.player;
using Mazzoli.player.util;

namespace Mazzoli
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            IUser first = new User("Alessandro");
            IUser second = new User("Stefano");

            IPlayer white = new Player(first, PlayerColor.White);
            IPlayer black = new Player(second, PlayerColor.Black);

            IPlayerPair pair = new PlayerPair(white, black);
            System.Console.WriteLine(pair.BlackPlayer.User.Username);
        }
    }
}
