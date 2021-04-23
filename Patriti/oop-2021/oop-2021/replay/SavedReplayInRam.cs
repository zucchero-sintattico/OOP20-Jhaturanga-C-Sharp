using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_2021.replay
{
    public class SavedReplayInRam : ISavedReplay
    {
        private readonly HashSet<ReplayData> _boardSet;
        
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
            return _boardSet.FirstOrDefault(board => string.Equals(matchId, board.MatchId));
        }

        public void Save(ReplayData replayData)
        {
            this._boardSet.Add(replayData);
        }
    }
}
