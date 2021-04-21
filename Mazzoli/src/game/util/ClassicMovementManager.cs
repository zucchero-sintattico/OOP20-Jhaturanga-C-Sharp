namespace Mazzoli.game.util
{
    public class ClassicMovementManager : IMovementManager
    {
        private readonly IGameController _gameController;

        public ClassicMovementManager(IGameController gameController)
        {
            _gameController = gameController;
        }
    }
}