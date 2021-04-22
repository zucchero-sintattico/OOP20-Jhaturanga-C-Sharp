using Jhaturanga_CSharp.Boards;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Movement.MovementManaging;
using Jhaturanga_CSharp.Pieces;
using NUnit.Framework;
using System;

namespace Jhaturanga_CSharp.Test
{

    public class TestPieceMovement
    {

        private readonly IPlayer whitePlayer = new Player(null, PlayerColor.WHITE);
        private readonly IPlayer blackPlayer = new Player(null, PlayerColor.BLACK);

        [Test]
        public void TestQueen()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.QUEEN, new BoardPosition(0, 0), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(1, 1)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(7, 7)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(0, 7)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(7, 0)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(5, 5)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(1, 4)));
        }

        [Test]
        public void TestKing()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.KING, new BoardPosition(5, 5), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(5, 5)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(4, 5)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(6, 4)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(3, 0)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(4, 4)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(5, 5))).GetPossibleMoves(board).Contains(new BoardPosition(6, 7)));
        }

        [Test]
        public void TestWhitePawn()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.PAWN, new BoardPosition(0, 0), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(0, 1)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(0, 2)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(1, 4)));
        }

        [Test]
        public void TestBlackPawn()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.PAWN, new BoardPosition(0, 7), this.blackPlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 7))).GetPossibleMoves(board).Contains(new BoardPosition(0, 6)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 7))).GetPossibleMoves(board).Contains(new BoardPosition(0, 5)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 7))).GetPossibleMoves(board).Contains(new BoardPosition(0, 4)));
        }

        [Test]
        public void TestBishop()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.BISHOP, new BoardPosition(1, 1), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(1, 1)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(7, 7)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(0, 0)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(7, 0)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(5, 5)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(1, 4)));
        }

        [Test]
        public void TestRook()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.ROOK, new BoardPosition(2, 5), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(1, 1)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(7, 5)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(1, 5)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(3, 0)));
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(2, 6)));
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(2, 5))).GetPossibleMoves(board).Contains(new BoardPosition(1, 4)));
        }

    }
}
