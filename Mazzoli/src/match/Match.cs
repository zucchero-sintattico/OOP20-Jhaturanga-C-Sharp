using System.Collections.Generic;
using Mazzoli.game;
using Mazzoli.match.history;
using Mazzoli.match.piece;
using Mazzoli.match.timer;
using Mazzoli.player;

namespace Mazzoli.match
{
    public class Match : IMatch
    {
        public string MatchId { get; }

        public IGame Game { get; }

        public IHistory History { get; }

        public ITimer Timer { get; }


        public MatchEndType? GetMatchEndType()
        {
            throw new System.NotImplementedException();
        }

        public MatchStatus GetMatchStatus()
        {
            throw new System.NotImplementedException();
        }

        public HashSet<IBoardPosition> GetPiecePossibleMoves(IPiece piece)
        {
            throw new System.NotImplementedException();
        }

        public IPlayer GetWinner()
        {
            throw new System.NotImplementedException();
        }

        public void Resign(IPlayer player)
        {
            throw new System.NotImplementedException();
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}