using System;

namespace Mazzoli
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser first = new User("Alessandro");
            IUser second = new User("Stefano");

            IPlayer white = new Player(first, PlayerColor.WHITE);
            IPlayer black = new Player(second, PlayerColor.BLACK);

            IPlayerPair pair = new PlayerPair(black, black);
            System.Console.WriteLine(pair.BlackPlayer.User.Username);
        }
    }
}
