using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Board;

namespace Jhaturanga_CSharp
{
    public class ClassicPieceMovementStrategies : AbstractPieceMovementStrategies
    {

        private class BishopStrategy : IMovementStrategy
        {
            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            private readonly int DOUBLE_INCREMENT = 2;
            public BishopStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public  ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();
                
                int yIncrement = piece.Player.Color.Equals(PlayerColor.WHITE) ? SINGLE_INCREMENT
                        : -SINGLE_INCREMENT;

                Predicate<IBoardPosition> OnlyIfEnemyIsPresent = (x) => board.GetPieceAtPosition(x) != null
                        && !board.GetPieceAtPosition(x).Player.Equals(piece.Player);

                ISet<IBoardPosition> destinations1 = AbstractPieceMovementStrategies.DestinationsFromFunction(pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y + yIncrement), piece, board, SINGLE_INCREMENT);
                ISet<IBoardPosition> destinations2 = AbstractPieceMovementStrategies.DestinationsFromFunction(pos => new BoardPosition(pos.X + -SINGLE_INCREMENT, pos.Y + yIncrement), piece, board, SINGLE_INCREMENT);

                foreach (IBoardPosition pos in destinations2)
                {
                    destinations1.Add(pos);
                }

                ISet<IBoardPosition> finalDestinations = new HashSet<IBoardPosition>();

                foreach (IBoardPosition pos in destinations1)
                {
                    if(OnlyIfEnemyIsPresent(pos))
                    {
                        destinations1.Add(pos);
                    }   
                }

                BoardPosition front = new BoardPosition(piece.PiecePosition.X,
                        piece.PiecePosition.Y + yIncrement);

                if (board.Contains(front) && board.GetPieceAtPosition(front) == null)
                {
                    positions.Add(front);
                }

                if (!piece.HasMoved && board.GetPieceAtPosition(front) == null && board
                        .GetPieceAtPosition(new BoardPosition(front.X, front.Y + yIncrement)) == null)
                {

                    foreach(IBoardPosition pos in AbstractPieceMovementStrategies.DestinationsFromFunction(pos => new BoardPosition(pos.X, pos.Y + yIncrement), piece, board, DOUBLE_INCREMENT))
                    {
                        positions.Add(pos);
                    }

                
                }

                return positions;
            }
        }

        private class KingStrategy : IMovementStrategy
        {

            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            private readonly int DOUBLE_INCREMENT = 2;
            public KingStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();

                foreach(IBoardPosition pos in Queen)

                positions.addAll(this.getQueenMovementStrategy(piece).getPossibleMoves(board).stream()
                        .filter(pos-> this.pieceDistanceFromPositionLessThan(piece, pos, SINGLE_INCREMENT))
                        .collect(Collectors.toSet()));

                if (!piece.hasAlreadyBeenMoved())
                {
                    positions.addAll(Stream.concat(
                            super.getDestinationsFromFunction(
                                    pos-> new BoardPositionImpl(pos.getX() - SINGLE_INCREMENT, pos.getY()), piece, board,
                                    DOUBLE_INCREMENT).stream(),
                            super.getDestinationsFromFunction(
                                    pos-> new BoardPositionImpl(pos.getX() + SINGLE_INCREMENT, pos.getY()), piece, board,
                                    DOUBLE_INCREMENT).stream())
                            .collect(Collectors.toSet()));
                    // Extra control on the castle
                    board.getPieceAtPosition(new BoardPositionImpl(piece.getPiecePosition().getX() - DOUBLE_INCREMENT,
                            piece.getPiecePosition().getY())).ifPresent(p->positions.remove(p.getPiecePosition()));

                    board.getPieceAtPosition(new BoardPositionImpl(piece.getPiecePosition().getX() + DOUBLE_INCREMENT,
                            piece.getPiecePosition().getY())).ifPresent(p->positions.remove(p.getPiecePosition()));
                }
                return Collections.unmodifiableSet(positions);
            }
        }
        protected override IMovementStrategy BishopMovementStrategy(IPiece piece)
        {
            return new BishopStrategy(piece);
        }

        protected override IMovementStrategy KingMovementStrategy(IPiece piece)
        {
            throw new NotImplementedException();
        }

        protected override IMovementStrategy KnightMovementStrategy(IPiece piece)
        {
            throw new NotImplementedException();
        }

        protected override IMovementStrategy PawnMovementStrategy(IPiece piece)
        {
            throw new NotImplementedException();
        }

        protected override IMovementStrategy QueenMovementStrategy(IPiece piece)
        {
            throw new NotImplementedException();
        }

        protected override IMovementStrategy RookMovementStrategy(IPiece piece)
        {
            throw new NotImplementedException();
        }
    }
}
