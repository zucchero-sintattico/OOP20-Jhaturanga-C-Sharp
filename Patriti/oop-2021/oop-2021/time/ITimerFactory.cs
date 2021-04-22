using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.time
{
    public interface ITimerFactory
    {

        /**
        * <summary>Equal timer for every player.</summary>
        *
        * <param> players  players how wont assign timer</param>
        * <param> duration of timer in second</param>
        * <returns> timer</returns>
        */

        Timer EqualTimer(List<IPlayer> players, double duration);



        /**
        * <summary>From timer map: <player, player time>.</summary>
        *
        * <param> playersTimer to assign every player with a personal time</param>
        * <returns>timer</returns>
        */
        Timer FromTimerMap(Dictionary<IPlayer, Double> playersTimer);
    }
}
