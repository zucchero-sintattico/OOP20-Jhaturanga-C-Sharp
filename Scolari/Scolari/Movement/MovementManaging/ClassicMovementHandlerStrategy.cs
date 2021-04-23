using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Pieces;

namespace Scolari.Movement.MovementManaging
{
    public class ClassicMovementHandlerStrategy : IMovementHandlerStrategy
    {
        
        private readonly IGameController gameController;
        private readonly IPieceMovementStrategies pieceMovementStrategies;
        private readonly ICastlingManager castlingManager;

        public ClassicMovementHandlerStrategy(IGameController gameController)
        {
            this.gameController = gameController;
            this.castlingManager = new CastlingManager(this.gameController);
            this.pieceMovementStrategies = gameController.GetPieceMovementStrategies();
        }

        public bool IsMovementPossible(IPieceMovement movement)
        {
            return this.PossibleDestinations(movement.PieceInvolved).Contains(movement.Destination);
        }

        public ISet<IBoardPosition> PossibleDestinations(IPiece piece)
        {
            ISet<IBoardPosition> destinations = new HashSet<IBoardPosition>();

            foreach(IBoardPosition possibleDestination in this.pieceMovementStrategies.PieceMovementStrategy(piece).GetPossibleMoves(this.gameController.GetBoard()))
            {
                IPieceMovement mov = new PieceMovement(piece, piece.PiecePosition, possibleDestination);

                if(this.ArePreliminarChecksOnCastlingValid(mov) && this.gameController.WouldNotBeInCheck(mov))
                {
                    destinations.Add(mov.Destination);
                }
            }

            return destinations;
        }

        private bool ArePreliminarChecksOnCastlingValid(IPieceMovement movement)
        {
            return !this.castlingManager.MightItBeCastle(movement) || this.castlingManager.IsCastlingFullyCorrect(movement);
        }

    }
}
