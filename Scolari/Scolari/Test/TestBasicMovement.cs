using NUnit.Framework;
using Scolari.Boards;
using Scolari.Pieces;

namespace Scolari.Test
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
