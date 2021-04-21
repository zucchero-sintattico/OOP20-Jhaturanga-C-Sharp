using Mazzoli.game.controller;
using Mazzoli.game.movementmanager;
using Mazzoli.game.type;

namespace Mazzoli.game.builder
{
    public class GameBuilder : IGameBuilder
    {
        private GameType? _type;
        private IGameController _gameController;
        private IMovementManager _movementManager;

        private bool _built = false;

        public IGameBuilder GameType(GameType type)
        {
            this._type = type;
            return this;
        }

        public IGameBuilder GameController(IGameController gameController)
        {
            this._gameController = gameController;
            return this;
        }

        public IGameBuilder MovementManager(IMovementManager movementManager)
        {
            this._movementManager = movementManager;
            return this;
        }

        public IGame Build()
        {
            if (_built)
            {
                throw new System.SystemException("Alredy Built");
            }

            if (this._type == null || this._gameController == null || this._movementManager == null)
            {
                throw new System.SystemException("All fields must be specified");
            }

            this._built = true;

            return new Game(this._type.GetValueOrDefault(), this._gameController, this._movementManager);
        }


    }
}