using Jhaturanga_CSharp.Boards;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Movement.MovementManaging;
using Jhaturanga_CSharp.Pieces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Jhaturanga_CSharp.Test
{

    public class TestBoard
    {
        [Test]
        public void TestBoardSize()
        {
            IBoard board = new Board(new HashSet<IPiece>(), 8, 8);

            Assert.True(board.Columns.Equals(8));
            Assert.True(board.Rows.Equals(8));
            Assert.True(board.GetPieces().Count.Equals(0));
        }

        [Test]
        public void TestBoardBuilder()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.KING, new BoardPosition(0, 0), null)).Build();

            Assert.True(board.Columns.Equals(8));
            Assert.True(board.Rows.Equals(8));
            Assert.True(board.GetPieces().Count.Equals(1));
            Assert.True(board.GetPieceAtPosition(new BoardPosition(0, 0)).Type.Equals(PieceType.KING));
        }

        [Test]
        public void TestBoardAdding()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.KING, new BoardPosition(0, 0), null)).Build();

            Assert.False(board.Add(new Piece(PieceType.ROOK, new BoardPosition(0, 0), null)));
            Assert.True(board.Add(new Piece(PieceType.ROOK, new BoardPosition(1, 0), null)));
        }

        [Test]
        public void TestBoardRemoving()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.KING, new BoardPosition(0, 0), null)).Build();

            Assert.True(board.Remove(new Piece(PieceType.KING, new BoardPosition(0, 0), null)));
            //Now the piece was removed so cant be found there
            Assert.False(board.Remove(new Piece(PieceType.KING, new BoardPosition(0, 0), null)));
        }

    }
}
