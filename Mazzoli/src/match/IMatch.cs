using System.Collections.Generic;
using Mazzoli.game;
using Mazzoli.match.history;
using Mazzoli.match.piece;
using Mazzoli.match.timer;
using Mazzoli.player;

namespace Mazzoli.match
{
    public interface IMatch
    {
        string MatchId { get; }
        IGame Game { get; }
        IHistory History { get; }
        ITimer Timer { get; }


        void Start();

        MatchStatus GetMatchStatus();
        MatchEndType? GetMatchEndType();
        IPlayer GetWinner();

        void Resign(IPlayer player);
        HashSet<IBoardPosition> GetPiecePossibleMoves(IPiece piece);
    }
}