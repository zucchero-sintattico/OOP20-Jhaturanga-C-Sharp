using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.time
{
    public class Timer : ITimer
    {

        private readonly Dictionary<IPlayer, double> playersTimers;

        private bool isRunning = true;
        private IPlayer actualPlayerTimer;
        private long initialUnixTime;

        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public Timer(Dictionary<IPlayer, double> playersTimers)
        {
            this.playersTimers = playersTimers;
        }

        public double GetRemaningTime(IPlayer player)
        {
            if (player.Equals(this.actualPlayerTimer))
            {
                double numberOfSecondsUsed = (DateTime.UtcNow - Jan1st1970).TotalSeconds - initialUnixTime;
                double remainingSecond = playersTimers.GetValueOrDefault(actualPlayerTimer) - numberOfSecondsUsed;
                if (remainingSecond < 0)
                {
                    remainingSecond = 0;
                }
                return remainingSecond;
            }
            return playersTimers.GetValueOrDefault(player);
        }

        public bool IsRunning()
        {
            return isRunning;
        }

        public void Start(IPlayer player)
        {
            this.actualPlayerTimer = player;
            this.initialUnixTime = (long)(DateTime.UtcNow - Jan1st1970).TotalSeconds;
            this.isRunning = true;
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        public void SwitchPlayer(IPlayer player)
        {
            this.playersTimers.Remove(actualPlayerTimer);
            this.playersTimers.Add(actualPlayerTimer, GetRemaningTime(actualPlayerTimer));
            this.Start(player);
        }
    }
}
