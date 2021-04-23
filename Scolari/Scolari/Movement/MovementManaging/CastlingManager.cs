using System;
using Scolari.Boards;
using Scolari.Pieces;

namespace Scolari.Movement.MovementManaging
{
    public class CastlingManager : ICastlingManager
    {

        private static readonly int LATERAL_INCREMENT = 1;

        private IGameController gameController;

        public CastlingManager(IGameController gameController)
        {
            this.gameController = gameController;
        }

        
        public void CheckAndExecuteCastling(IPieceMovement movement)
        {
            if (this.IsCastlingFullyCorrect(movement))
            {
                this.ExecuteCastle(movement);
            }
        }

        
        public bool MightItBeCastle(IPieceMovement movement)
        {
            return this.ArePositionalConditionsCorrectToCastle(movement);
        }

        
        public bool IsCastlingFullyCorrect(IPieceMovement movement)
        {
            return this.ArePositionalConditionsCorrectToCastle(movement) && this.ExtraChecksOnCastling(movement);
        }

        private bool ArePositionalConditionsCorrectToCastle(IPieceMovement movement)
        {
            return movement.PieceInvolved.Type.Equals(PieceType.KING)
                    && Math.Abs(movement.Origin.X - movement.Destination.X) == 2
                    && movement.Origin.Y == movement.Destination.Y;
        }

        private bool ExtraChecksOnCastling(IPieceMovement movement)
        {
            return this.IsPathToCastleFreeFromCheck(movement)
                    && this.GetClosestRookInRangeThatHasntMovedYet(movement) != null;
        }

        private bool IsPathToCastleFreeFromCheck(IPieceMovement movement)
        {
            int increment = movement.Origin.X > movement.Destination.X ? -LATERAL_INCREMENT
                    : LATERAL_INCREMENT;

            IBoardPosition nextToItPos = new BoardPosition(movement.Origin.X + increment,
                    movement.Origin.Y);

            return this.gameController
                    .WouldNotBeInCheck(new PieceMovement(movement.PieceInvolved, movement.Origin, nextToItPos));
        }

        private IPiece GetClosestRookInRangeThatHasntMovedYet(IPieceMovement mov)
        {
            foreach(IPiece piece in this.gameController.GetBoard().GetPieces())
            {
                if(piece.Type.Equals(PieceType.ROOK) && Math.Abs(piece.PiecePosition.X - mov.Destination.X) <= 2
                            && piece.PiecePosition.Y == mov.Destination.Y
                            && piece.Player.Equals(mov.PieceInvolved.Player) && !piece.HasMoved)
                    {
                    return piece;
                }
            }

            return null;
        }

        private void ExecuteCastle(IPieceMovement movement)
        {
            int increment = movement.Origin.X > movement.Destination.X ? LATERAL_INCREMENT
                    : -LATERAL_INCREMENT;

            IPiece rook = this.GetClosestRookInRangeThatHasntMovedYet(movement);

            if (rook != null)
            {
                rook.PiecePosition = new BoardPosition(movement.Destination.X + increment, rook.PiecePosition.Y);
                movement.Execute();
            }


        }
    }
}
