using System;

namespace OOP20.user
{
    interface IUser
    {
        /// <returns>the name of the user that is unique and not null</returns>
        string Username { get; }

        /// <returns>the Hashed password of the user</returns>
        string? HashedPassword { get; }

        /// <returns>the number of win match</returns>
        int WinCount { get; }

        /// <returns>the number of lost match</returns>
        int LostCount { get; }

        /// <returns>the number of draw match</returns>
        int DrawCount { get; }

        /// <returns>the number of match played</returns>
        int PlayedMatchCount { get; }

        /// <summary>Increase the win Count</summary>
        void IncreaseWinCount();

        /// <summary>Increase the draw Count</summary>
        void IncreaseDrawCount();

        /// <summary>Increase the lost Count</summary>
        void IncreaseLostCount();
    }
}
