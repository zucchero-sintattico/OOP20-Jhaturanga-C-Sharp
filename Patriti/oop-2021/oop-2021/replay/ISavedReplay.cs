using System;
using System.Collections.Generic;

namespace oop_2021.replay
{
    public interface ISavedReplay
    {
        
        /// <summary>
        /// Saving board.
        /// </summary>
        /// <param name="replayData">replayData to saving</param>
        void Save(ReplayData replayData);

        /// <summary>
        /// Gets the saved replay
        /// </summary>
        /// <param name="matchId">the match ID</param>
        /// <returns>board with the specified ID</returns>
        ReplayData GetSavedReplay(string matchId);
        
        /// <summary>
        /// gets all the boards
        /// </summary>
        /// <returns>all saved boards</returns>
        HashSet<ReplayData> GetAllBoards();

    }
}
