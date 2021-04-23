using System;
using System.Collections.Generic;
using oop_2021.utility;

namespace oop_2021.replay
{
    public class ReplayDataBuilder
    {
       

        private string _matchId;
        private DateTime _date;
        private User _whiteUser;
        private User _blackUser;
        private List<Board> _boards;
        private GameType _gameType;

        public ReplayDataBuilder MatchId(string matchId)
        {
            this._matchId = matchId;
            return this;
        }

        public ReplayDataBuilder Date( DateTime date)
        {
            this._date = date;
            return this;
        }
        
        public ReplayDataBuilder WhiteUser( User whiUser)
        {
            this._whiteUser = whiUser;
            return this;
        }

        public ReplayDataBuilder BlackUser( User blackUser)
        {
            this._blackUser = blackUser;
            return this;

        }
        
        public ReplayDataBuilder Boards( List<Board> boards)
        {
            this._boards = boards;
            return this;
        }
        
        public ReplayDataBuilder GameType( GameType gameType)
        {
            this._gameType = gameType;
            return this;
        }
        
        public ReplayData Build()
        {
            return new ReplayData(_matchId, _date, _whiteUser, _blackUser, _boards, _gameType);
        }
    }
}
