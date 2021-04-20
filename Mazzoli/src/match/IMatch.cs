using System.Collections.Generic;
interface IMatch
{
    string MatchID { get; }
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