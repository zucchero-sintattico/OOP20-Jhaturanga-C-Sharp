using System.Collections.Generic;
using System.Threading;
using oop_2021.time;
using oop_2021.utility;
using Xunit;
using Timer = oop_2021.time.Timer;

namespace oop_2021.Test
{
    public class TimerTest
    {
        [Fact]
        public void TimerTest1()
        {

            IPlayer player1 = new Player();
            IPlayer player2 = new Player();
            IDictionary<IPlayer, double> mapTest = new Dictionary<IPlayer, double>(){
                    { player1, 10 },
                    { player2, 10 },
                };

            ITimer timer = new Timer(mapTest);

            Assert.Equal(10, (int)timer.GetRemainingTime(player1));
            timer.Start(player1);
            Thread.Sleep(1000);
            Assert.Equal(8, (int)timer.GetRemainingTime(player1));
        }



        [Fact]
        public void TimerTest2()
        {
            IPlayer player1 = new Player();
            IPlayer player2 = new Player();

            List<IPlayer> players = new List<IPlayer>
            {
                player1,
                player2
            };

            TimerFactory timerFattory = new TimerFactory();
            ITimer timer = timerFattory.EqualTimer(players, 10);

            Assert.Equal(10, (int)timer.GetRemainingTime(player1));
            timer.Start(player1);
            timer.SwitchPlayer(player2);
            Thread.Sleep(1000);
            Assert.Equal(8, (int)timer.GetRemainingTime(player2));
        }



    }

}
