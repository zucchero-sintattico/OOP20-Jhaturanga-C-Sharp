using System;
using System.Collections.Generic;

namespace oop_2021.time
{
    public class TimerFactory : ITimerFactory
    {
        public TimerFactory()
        {
        }

        public Timer EqualTimer(List<IPlayer> players, double duration)
        {
            Dictionary<IPlayer, Double> playerTimerMap = new Dictionary<IPlayer, double>();

            players.ForEach((elem) => playerTimerMap.Add(elem, duration));
            return this.FromTimerMap(playerTimerMap);
        }

        public Timer FromTimerMap(Dictionary<IPlayer, double> playersTimer)
        {
            return new Timer(playersTimer);
        }

    }
}
