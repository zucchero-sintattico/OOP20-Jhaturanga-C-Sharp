using System;
using System.Collections.Generic;
using System.Threading;
using oop_2021.time;
using Xunit;
using Timer = oop_2021.time.Timer;

namespace oop_2021
{
public class UnitTest1
{
        readonly static IPlayer player1 = new Player();
        readonly static IPlayer player2 = new Player();
        readonly Dictionary<IPlayer, double> mapTest = new Dictionary<IPlayer, double>()
    {
        { player1, 10 },
        { player2, 10 },
    };
        [Fact]
    public void TimerTest1()
    {
        ITimer timer = new Timer(mapTest);

            Assert.Equal(10,(int)timer.GetRemaningTime(player1) );
            timer.Start(player1);
            Console.WriteLine(timer.GetRemaningTime(player1));
            Thread.Sleep(1000);
            Assert.Equal(8, (int)timer.GetRemaningTime(player1) );
        }
}
}
