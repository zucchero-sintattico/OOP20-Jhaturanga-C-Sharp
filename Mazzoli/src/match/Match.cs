using System.Collections.Generic;

class Match : IMatch
{
    public string MatchID { get; }

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