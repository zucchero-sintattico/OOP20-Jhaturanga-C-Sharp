interface IGame
{
    GameType Type { get; }
    IGameController Controller { get; }
    IMovementManager MovementManager { get; }

    static IGameBuilder Builder()
    {
        return new GameBuilder();
    }
}