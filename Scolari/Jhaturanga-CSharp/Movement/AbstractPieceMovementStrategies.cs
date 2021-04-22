﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using Jhaturanga_CSharp.Movement.MovementManager;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Board;

namespace Jhaturanga_CSharp.Movement
{
    abstract class AbstractPieceMovementStrategies : IPieceMovementStrategies
    {
        public static IEnumerable<T> Iterate<T>(T seed, Func<T, T> unaryOperator)
        {
            while (true)
            {
                yield return seed;
                seed = unaryOperator(seed);
            }
        }

        private readonly Func<KeyValuePair<IBoardPosition, KeyValuePair<int, int>>, IBoardPosition> SumBoardPosWithPair = (p) => new BoardPosition(p.Key.X + p.Value.Key, p.Key.Y + p.Value.Value);
        private Func<KeyValuePair<int, int>, Func<IBoardPosition, IBoardPosition>> FuncFromAxis => (axis) => (p) => SumBoardPosWithPair(new KeyValuePair<IBoardPosition, KeyValuePair<int,int>>(p,axis));

        private readonly Func<IBoard, int> fromBoardToMaximumLimit = (board) => board.Rows + board.Columns;

        public IMovementStrategy PieceMovementStrategy(IPiece piece)
        {
            switch(piece.Type)
            {
                case PieceType.BISHOP:
                    return this.BishopMovementStrategy(piece);
                case PieceType.KNIGHT:
                    return this.BishopMovementStrategy(piece);
                case PieceType.ROOK:
                    return this.RookMovementStrategy(piece);
                case PieceType.KING:
                    return this.KingMovementStrategy(piece);
                case PieceType.QUEEN:
                    return this.QueenMovementStrategy(piece);
                case PieceType.PAWN:
                    return this.PawnMovementStrategy(piece);
                default:
                    return null;
            }
        }

        protected static ISet<IBoardPosition> DestinationsFromFunction(Func<IBoardPosition, IBoardPosition> function, IPiece piece, IBoard board, int limit)
        {
            ArrayList destinations = new ArrayList();
            var skip = function(piece.PiecePosition);
            int it = 0;
            while (it<=limit && IsPositionEmpty(skip, board, piece) && board.Contains(skip))
            {
                skip = function(skip);
                destinations.Add(skip);
                it++;
            }
            return (destinations.Cast<IBoardPosition>().Where(e => IsEnemyOrEmpty(e, board, piece)).ToHashSet());
        }

        private static bool IsEnemyOrEmpty(IBoardPosition pos, IBoard board, IPiece piece)
        {
            if (board.GetPieceAtPosition(pos) != null)
            {
                return board.GetPieceAtPosition(pos).Player.Equals(piece.Player);
            }
            return false;
        }

        private static bool IsPositionEmpty(IBoardPosition pos, IBoard board, IPiece piece)
        {
            return board.GetPieceAtPosition(pos) == null;
        }

        protected abstract IMovementStrategy PawnMovementStrategy(IPiece piece);

        protected abstract IMovementStrategy RookMovementStrategy(IPiece piece);

        protected abstract IMovementStrategy QueenMovementStrategy(IPiece piece);

        protected abstract IMovementStrategy KingMovementStrategy(IPiece piece);

        protected abstract IMovementStrategy BishopMovementStrategy(IPiece piece);

        protected abstract IMovementStrategy KnightMovementStrategy(IPiece piece);

    }
}
