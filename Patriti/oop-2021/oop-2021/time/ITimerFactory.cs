using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.time
{
    public interface ITimerFactory
    {
        /// <summary>
        /// Equal timer for every player.
        /// </summary>
        /// <param name="players">the players</param>
        /// <param name="duration">the duration of the timer in seconds</param>
        /// <returns>the timer</returns>
        Timer EqualTimer(List<IPlayer> players, double duration);

        
        /// <summary>
        /// Generate a timer from the specified Dictionary of Player -> Time
        /// </summary>
        /// <param name="playersTimer">the dictionary Player -> Time</param>
        /// <returns>the timer</returns>
        Timer FromTimerMap(Dictionary<IPlayer, double> playersTimer);
    }
}
