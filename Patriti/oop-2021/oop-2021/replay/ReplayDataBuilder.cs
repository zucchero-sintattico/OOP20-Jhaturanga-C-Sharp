using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.replay
{
    public class ReplayDataBuilder
    {
       

        private string matchID;


        private DateTime date;


        private User whiteUser;


        private User blackUser;


        private List<Board> boards;

     
        private GameType gameType;

        public ReplayDataBuilder MatchID( string matchID)
        {
            this.matchID = matchID;
            return this;
        }

        public ReplayDataBuilder Date( DateTime date)
        {
            this.date = date;
            return this;
        }


        public ReplayDataBuilder WhiteUser( User whiUser)
        {
            this.whiteUser = whiUser;
            return this;
        }

        public ReplayDataBuilder BlackUser( User blackUser)
        {
            this.blackUser = blackUser;
            return this;

        }


        public ReplayDataBuilder Boards( List<Board> boards)
        {
            this.boards = boards;
            return this;
        }

        
        public ReplayDataBuilder GameType( GameType gameType)
        {
            this.gameType = gameType;
            return this;
        }


        public ReplayData Build()
        {
            return new ReplayData(matchID, date, whiteUser, blackUser, boards, gameType);
        }
    }
}
