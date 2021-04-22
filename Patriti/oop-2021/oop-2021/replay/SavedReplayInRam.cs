using System;
using System.Collections.Generic;

namespace oop_2021.replay
{
    public class SavedReplayInRam : ISavedReplay
    {
        readonly HashSet<ReplayData> boardSet;
        public SavedReplayInRam()
        {
            boardSet = new HashSet<ReplayData>();
        }

        public HashSet<ReplayData> GetAllBoards()
        {
            return boardSet;
        }

        public ReplayData GetSavedReplay(string matchID)
        {
            foreach (ReplayData board in boardSet) {
                if (string.Equals(matchID, board.MatchID)) {
                    return board;
                }
            }
            return null;

        }

        public void Save(ReplayData replayData)
        {
            this.boardSet.Add(replayData);
        }
    }
}
