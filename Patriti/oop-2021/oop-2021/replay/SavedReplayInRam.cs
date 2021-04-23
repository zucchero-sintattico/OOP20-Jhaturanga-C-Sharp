using System;
using System.Collections.Generic;

namespace oop_2021.replay
{
    public class SavedReplayInRam : ISavedReplay
    {
        readonly HashSet<ReplayData> _boardSet;
        public SavedReplayInRam()
        {
            _boardSet = new HashSet<ReplayData>();
        }

        public HashSet<ReplayData> GetAllBoards()
        {
            return _boardSet;
        }

        public ReplayData GetSavedReplay(string matchId)
        {
            foreach (ReplayData board in _boardSet) {
                if (string.Equals(matchId, board.MatchId)) {
                    return board;
                }
            }
            return null;

        }

        public void Save(ReplayData replayData)
        {
            this._boardSet.Add(replayData);
        }
    }
}
