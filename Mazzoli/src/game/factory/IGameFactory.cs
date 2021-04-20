interface IGameFactory
{
    IGame Classic(IPlayerPair playerPair);

    IGame PawnHordeVariant(IPlayerPair playerPair);
}