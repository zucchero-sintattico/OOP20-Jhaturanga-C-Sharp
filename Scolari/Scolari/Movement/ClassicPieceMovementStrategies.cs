using System;
using System.Collections.Generic;
using System.Linq;
using Scolari.Boards;
using Scolari.Pieces;
using Scolari.Util;

namespace Scolari.Movement
{
    public class ClassicPieceMovementStrategies : AbstractPieceMovementStrategies
    {

        private class PawnStrategy : IMovementStrategy
        {
            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            private readonly int DOUBLE_INCREMENT = 2;
            public PawnStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public  ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                int yIncrement = piece.Player.Color.Equals(PlayerColor.WHITE) ? SINGLE_INCREMENT
                        : -SINGLE_INCREMENT;

                Predicate<IBoardPosition> OnlyIfEnemyIsPresent = (x) => board.GetPieceAtPosition(x) != null
                        && !board.GetPieceAtPosition(x).Player.Equals(piece.Player);

                ISet<IBoardPosition> possibleDestinations = new HashSet<IBoardPosition>();

                possibleDestinations.UnionWith(AbstractPieceMovementStrategies.DestinationsFromFunction(
                    pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y + yIncrement), piece, board, SINGLE_INCREMENT));
                possibleDestinations.UnionWith(AbstractPieceMovementStrategies.DestinationsFromFunction(
                    pos => new BoardPosition(pos.X + -SINGLE_INCREMENT, pos.Y + yIncrement), piece, board, SINGLE_INCREMENT));               

                ISet<IBoardPosition> finalDestinations = possibleDestinations.Cast<IBoardPosition>().Where(pos => OnlyIfEnemyIsPresent(pos)).ToHashSet();

                BoardPosition front = new BoardPosition(piece.PiecePosition.X,
                        piece.PiecePosition.Y + yIncrement);

                if (board.Contains(front) && board.GetPieceAtPosition(front) == null)
                {
                    finalDestinations.Add(front);
                }

                if (!piece.HasMoved && board.GetPieceAtPosition(front) == null && board
                        .GetPieceAtPosition(new BoardPosition(front.X, front.Y + yIncrement)) == null)
                {
                        finalDestinations.UnionWith(AbstractPieceMovementStrategies.DestinationsFromFunction(
                        pos => new BoardPosition(pos.X, pos.Y + yIncrement), piece, board, DOUBLE_INCREMENT));
                }
                return finalDestinations;
            }
        }

        private class KingStrategy : IMovementStrategy
        {
            private readonly IPieceMovementStrategies movStr = new ClassicPieceMovementStrategies();
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

                foreach(IBoardPosition pos in movStr.PieceMovementStrategy(new Piece(PieceType.QUEEN, this.piece.PiecePosition, piece.Player)).GetPossibleMoves(board))
                {
                    if(PieceDistanceFromPositionLessThan(piece, pos, SINGLE_INCREMENT))
                    {
                        positions.Add(pos);
                    }
                }

                if (!piece.HasMoved)
                {      
                    positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X - SINGLE_INCREMENT, pos.Y), piece, board, DOUBLE_INCREMENT));
                    positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y), piece, board, DOUBLE_INCREMENT));

                    IPiece firstPieceToCheck = board.GetPieceAtPosition(new BoardPosition(piece.PiecePosition.X - DOUBLE_INCREMENT, piece.PiecePosition.Y));
                    IPiece secondPieceToCheck = board.GetPieceAtPosition(new BoardPosition(piece.PiecePosition.X + DOUBLE_INCREMENT, piece.PiecePosition.Y));
                    // Extra control on the castle
                    if (firstPieceToCheck != null) 
                    {
                        positions.Remove(firstPieceToCheck.PiecePosition);
                    } 
                    if(secondPieceToCheck != null)
                    {
                        positions.Remove(secondPieceToCheck.PiecePosition);
                    }
                }
                return positions;
            }
        }

        private class QueenStrategy : IMovementStrategy
        {
            private readonly IPieceMovementStrategies movStr = new ClassicPieceMovementStrategies();
            private readonly IPiece piece;
            public QueenStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();

                positions.UnionWith(movStr.PieceMovementStrategy(new Piece(PieceType.ROOK, piece.PiecePosition, piece.Player)).GetPossibleMoves(board));
                positions.UnionWith(movStr.PieceMovementStrategy(new Piece(PieceType.BISHOP, piece.PiecePosition, piece.Player)).GetPossibleMoves(board));

                return positions;
            }
        }

        private class KnightStrategy : IMovementStrategy
        {
            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            private readonly int DOUBLE_INCREMENT = 2;
            public KnightStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();
                new List<int>() { SINGLE_INCREMENT, -SINGLE_INCREMENT }.ForEach(single => {
                    new List<int>() { DOUBLE_INCREMENT, -DOUBLE_INCREMENT }.ForEach(byTwo =>
                    {
                        positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + single, pos.Y + byTwo), this.piece, board, SINGLE_INCREMENT));
                        positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + byTwo, pos.Y + single), this.piece, board, SINGLE_INCREMENT));
                    });
                });

                return positions;
            }
        }

        private class RookStrategy : IMovementStrategy
        {
            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            public RookStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                int limit = board.Columns + board.Rows;
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();

                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X, pos.Y + SINGLE_INCREMENT), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X, pos.Y - SINGLE_INCREMENT), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X - SINGLE_INCREMENT, pos.Y), piece, board, limit));

                return positions;
            }
        }

        private class BishopStrategy : IMovementStrategy
        {
            private readonly IPiece piece;
            private readonly int SINGLE_INCREMENT = 1;
            public BishopStrategy(IPiece piece)
            {
                this.piece = piece;
            }

            public ISet<IBoardPosition> GetPossibleMoves(IBoard board)
            {
                int limit = board.Columns + board.Rows;
                ISet<IBoardPosition> positions = new HashSet<IBoardPosition>();

                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y + SINGLE_INCREMENT), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X + SINGLE_INCREMENT, pos.Y - SINGLE_INCREMENT), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X - SINGLE_INCREMENT, pos.Y + SINGLE_INCREMENT), piece, board, limit));
                positions.UnionWith(DestinationsFromFunction(pos => new BoardPosition(pos.X - SINGLE_INCREMENT, pos.Y - SINGLE_INCREMENT), piece, board, limit));

                return positions;
            }
        }

        public static bool PieceDistanceFromPositionLessThan(IPiece piece,
        IBoardPosition positionFromWhichCalculateDistance, int distanceMathModule)
        {
            return DistanceBetweenBoardPositions(piece.PiecePosition, positionFromWhichCalculateDistance).X <= distanceMathModule
                    && DistanceBetweenBoardPositions(piece.PiecePosition, positionFromWhichCalculateDistance).Y <= distanceMathModule;
        }

        public static IBoardPosition DistanceBetweenBoardPositions(IBoardPosition p1, IBoardPosition p2)
        {
            return new BoardPosition(Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        protected override IMovementStrategy PawnMovementStrategy(IPiece piece)
        {
            return new PawnStrategy(piece);
        }

        protected override IMovementStrategy KingMovementStrategy(IPiece piece)
        {
            return new KingStrategy(piece);
        }

        protected override IMovementStrategy KnightMovementStrategy(IPiece piece)
        {
            return new KnightStrategy(piece);
        }

        protected override IMovementStrategy BishopMovementStrategy(IPiece piece)
        {
            return new BishopStrategy(piece);
        }

        protected override IMovementStrategy QueenMovementStrategy(IPiece piece)
        {
            return new QueenStrategy(piece);
        }

        protected override IMovementStrategy RookMovementStrategy(IPiece piece)
        {
            return new RookStrategy(piece);
        }
    }
}
