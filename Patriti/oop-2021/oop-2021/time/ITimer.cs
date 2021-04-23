using System;
using oop_2021.utility;

namespace oop_2021.time
{
    public interface ITimer
    {

        /// <summary>
        /// Get the remaining time of the specified player
        /// </summary>
        /// <param name="player">the player</param>
        /// <returns>the remaining time of the player</returns>
        double GetRemainingTime(IPlayer player);
        
        /// <summary>
        /// Start the timer for the selected player.
        /// </summary>
        /// <param name="player">the player which you want to start</param>
        void Start(IPlayer player);
        
        /// <summary>
        /// Stop the timer.
        /// </summary>
        void Stop();
        
        /// <summary>
        /// Check if the timer is running.
        /// </summary>
        /// <returns>true if the timer is running, false otherwise</returns>
        bool IsRunning();
        
        /// <summary>
        /// Stop the timer of the current player and start the timer of the selected player.
        /// </summary>
        /// <param name="player">the player which want to switch to</param>
        void SwitchPlayer(IPlayer player);



    }
}
