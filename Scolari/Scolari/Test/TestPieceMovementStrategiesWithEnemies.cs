using Jhaturanga_CSharp.Boards;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Movement.MovementManaging;
using Jhaturanga_CSharp.Pieces;
using NUnit.Framework;
using System;

namespace Jhaturanga_CSharp.Test
{

    public class TestPieceMovementStrategiesWithEnemies
    {

        private readonly IPlayer whitePlayer = new Player(null, PlayerColor.WHITE);
        private readonly IPlayer blackPlayer = new Player(null, PlayerColor.BLACK);

        [Test]
        public void TestQueenCaptureAndMovement()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8)
                .AddPiece(new Piece(PieceType.QUEEN, new BoardPosition(0, 0), this.whitePlayer))
                .AddPiece(new Piece(PieceType.ROOK, new BoardPosition(2, 0), this.blackPlayer))
                .Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            //Test that the queen can eat the rook
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(2, 0)));
            //But cant go past it
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0, 0))).GetPossibleMoves(board).Contains(new BoardPosition(3, 0)));
        }

        [Test]
        public void TestWhitePawnsCapture()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8)
                .AddPiece(new Piece(PieceType.PAWN, new BoardPosition(1, 1), this.whitePlayer))
                .AddPiece(new Piece(PieceType.ROOK, new BoardPosition(1, 2), this.blackPlayer))
                .AddPiece(new Piece(PieceType.ROOK, new BoardPosition(0, 2), this.blackPlayer))
                .Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            //Test that the pawn can eat the rook on the left
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(0, 2)));
            //But cant capture the one in front of it
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(1, 2)));
            //And cant also go past it with the double movement
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 1))).GetPossibleMoves(board).Contains(new BoardPosition(1, 3)));
        }

        [Test]
        public void TestBlackPawnsCapture()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8)
                .AddPiece(new Piece(PieceType.PAWN, new BoardPosition(1, 6), this.blackPlayer))
                .AddPiece(new Piece(PieceType.ROOK, new BoardPosition(1, 5), this.whitePlayer))
                .AddPiece(new Piece(PieceType.ROOK, new BoardPosition(0, 5), this.whitePlayer))
                .Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            //Test that the pawn can eat the rook on the left
            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 6))).GetPossibleMoves(board).Contains(new BoardPosition(0, 5)));
            //But cant capture the one in front of it
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 6))).GetPossibleMoves(board).Contains(new BoardPosition(1, 5)));
            //And cant also go past it with the double movement
            Assert.False(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(1, 6))).GetPossibleMoves(board).Contains(new BoardPosition(1, 4)));
        }

    }
}
