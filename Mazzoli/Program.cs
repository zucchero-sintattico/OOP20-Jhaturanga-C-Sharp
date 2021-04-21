using System;
using Mazzoli.player;
using Mazzoli.player.user;

namespace Mazzoli
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            IUser first = new User("Alessandro");
            IUser second = new User("Stefano");

            IPlayer white = new Player(first, PlayerColor.WHITE);
            IPlayer black = new Player(second, PlayerColor.BLACK);

            IPlayerPair pair = new PlayerPair(white, black);
            System.Console.WriteLine(pair.BlackPlayer.User.Username);
        }
    }
}
