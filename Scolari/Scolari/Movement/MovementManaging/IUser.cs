using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IUser
    {
        /// <summary>
        /// returns the name of the user that is unique and not null
        /// </summary>
        string Username { get; }

        /// <summary>
        /// returns the Hashed password of the user
        /// </summary>
        string HashedPassword { get; }

        /// <summary>
        /// returns the number of win match
        /// </summary>
        int WinCount { get; }

        /// <summary>
        /// returns the number of win match
        /// </summary>
        int LostCount { get; }

        /// <summary>
        /// returns the number of draw match
        /// </summary>
        int DrawCount { get; }

        /// <summary>
        /// returns the number of match played
        /// </summary>
        int PlayedMatchCount { get; }

        /// <summary>
        /// Increase the win Count.
        /// </summary>
        void IncreaseWinCount();

        /// <summary>
        /// Increase the draw Count.
        /// </summary>
        void IncreaseDrawCount();

        /// <summary>
        /// Increase the lost Count.
        /// </summary>
        void IncreaseLostCount();

    }
}
