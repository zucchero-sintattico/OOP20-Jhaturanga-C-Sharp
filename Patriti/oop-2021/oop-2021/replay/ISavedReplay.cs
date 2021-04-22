using System;
using System.Collections.Generic;

namespace oop_2021.replay
{
    public interface ISavedReplay
    {

         /**
         * Saving board.
         *
         * <param> replayData to saving.</param>
         * 
         */
        void Save(ReplayData replayData);

        /**
         * Gets the saved replay.
         *
         * <param>matchID the match ID</param>
         * <return>board witch have this ID</return>
         */
        ReplayData GetSavedReplay(String matchID);

        /**
         * Gets the all boards.
         *
         * @return all saved boards.
         */
        HashSet<ReplayData> GetAllBoards();

    }
}
