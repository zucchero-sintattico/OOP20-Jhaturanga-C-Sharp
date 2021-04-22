using Jhaturanga_CSharp.Boards;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Movement.MovementManaging;
using Jhaturanga_CSharp.Pieces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Jhaturanga_CSharp.Test
{

    public class TestBasicMovement
    {

        [Test]
        public void TestSimpleMovement()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.KING, new BoardPosition(0, 0), null)).Build();

            board.GetPieceAtPosition(new BoardPosition(0, 0)).PiecePosition = new BoardPosition(1, 1);

            Assert.True(board.GetPieceAtPosition(new BoardPosition(0, 0)) == null);
            Assert.True(board.GetPieceAtPosition(new BoardPosition(1, 1)).Type.Equals(PieceType.KING));
        }

    }
}
