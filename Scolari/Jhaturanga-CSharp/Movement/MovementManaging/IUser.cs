using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface IUser
    {
        /// <summary>
        /// 
        /// </summary>
        string Username { get; }

        /// <summary>
        /// 
        /// </summary>
        string HashedPassword { get; }

        /// <summary>
        /// 
        /// </summary>
        int WinCount { get; }

        /// <summary>
        /// 
        /// </summary>
        int LostCount { get; }

        /// <summary>
        /// 
        /// </summary>
        int DrawCount { get; }

        /// <summary>
        /// 
        /// </summary>
        int PlayedMatchCount { get; }

        /// <summary>
        /// 
        /// </summary>
        void IncreaseWinCount();

        /// <summary>
        /// 
        /// </summary>
        void IncreaseDrawCount();

        /// <summary>
        /// 
        /// </summary>
        void IncreaseLostCount();

    }
}
