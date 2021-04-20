class GameBuilder : IGameBuilder
{
    private GameType? type;
    private IGameController gameController;
    private IMovementManager movementManager;

    private bool built = false;

    public IGameBuilder GameType(GameType type)
    {
        this.type = type;
        return this;
    }

    public IGameBuilder GameController(IGameController gameController)
    {
        this.gameController = gameController;
        return this;
    }

    public IGameBuilder MovementManager(IMovementManager movementManager)
    {
        this.movementManager = movementManager;
        return this;
    }

    public IGame build()
    {
        if (built)
        {
            throw new System.SystemException("Alredy Built");
        }
        if (this.type == null || this.gameController == null || this.movementManager == null)
        {
            throw new System.SystemException("All fields must be specified");
        }
        this.built = true;

        return new Game(this.type.GetValueOrDefault(), this.gameController, this.movementManager);
    }


}