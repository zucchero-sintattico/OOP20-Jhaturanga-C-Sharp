using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.replay
{
    public class ReplayData
    {


        public string MatchId { get; }
        public DateTime Date { get; }
        public User WhiteUser { get; }
        public User BlackUser { get; }
        public List<Board> Boards { get; }
        public GameType GameType { get; }

        public ReplayData(String matchId, DateTime date, User whiteUser, User blackUser,
             List<Board> boards, GameType gameType)
        {
            this.MatchId = matchId;
            this.Date = date;
            this.WhiteUser = whiteUser;
            this.BlackUser = blackUser;
            this.Boards = boards;
            this.GameType = gameType;
        }

    }


}
