using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.time
{
    public class Timer : ITimer
    {

        private readonly IDictionary<IPlayer, double> _playersTimers;
        private bool _isRunning = true;
        private IPlayer _actualPlayerTimer;
        private long _initialUnixTime;
        private static readonly DateTime Jan1St1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public Timer(IDictionary<IPlayer, double> playersTimers)
        {
            this._playersTimers = playersTimers;
        }

        public double GetRemainingTime(IPlayer player)
        {
            if (player.Equals(this._actualPlayerTimer))
            {
                double numberOfSecondsUsed = (DateTime.UtcNow - Jan1St1970).TotalSeconds - _initialUnixTime;
                double remainingSecond = _playersTimers[_actualPlayerTimer] - numberOfSecondsUsed;
                if (remainingSecond < 0)
                {
                    remainingSecond = 0;
                }
                return remainingSecond;
            }
            return _playersTimers[player];
        }

        public bool IsRunning()
        {
            return _isRunning;
        }

        public void Start(IPlayer player)
        {
            this._actualPlayerTimer = player;
            this._initialUnixTime = (long)(DateTime.UtcNow - Jan1St1970).TotalSeconds;
            this._isRunning = true;
        }

        public void Stop()
        {
            this._isRunning = false;
        }

        public void SwitchPlayer(IPlayer player)
        {
            this._playersTimers.Remove(_actualPlayerTimer);
            this._playersTimers.Add(_actualPlayerTimer, GetRemainingTime(_actualPlayerTimer));
            this.Start(player);
        }
    }
}
