interface IGameBuilder
{
    IGameBuilder GameType(GameType type);

    IGameBuilder GameController(IGameController gameController);

    IGameBuilder MovementManager(IMovementManager movementManager);

    IGame build();
}