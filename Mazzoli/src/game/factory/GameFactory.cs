class GameFactory : IGameFactory
{
    public IGame Classic(IPlayerPair playerPair)
    {
        return new Game(GameType.CLASSIC, null, null);
    }

    public IGame PawnHordeVariant(IPlayerPair playerPair)
    {
        return new Game(GameType.PAWN_HORDE, null, null);
    }
}