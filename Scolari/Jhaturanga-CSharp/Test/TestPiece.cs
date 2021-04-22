using Jhaturanga_CSharp.Board;
using Jhaturanga_CSharp.Movement;
using Jhaturanga_CSharp.Movement.MovementManaging;
using Jhaturanga_CSharp.Pieces;
using NUnit.Framework;

namespace Jhaturanga_CSharp.Test
{

    public class TestPiece
    {

        private readonly IPlayer whitePlayer = new Player(null, PlayerColor.WHITE);
        private readonly IPlayer blackPlayer = new Player(null, PlayerColor.BLACK);

        [Test]
        public void TestBoard()
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            IBoard board = boardBuilder.Columns(8).Rows(8).AddPiece(new Piece(PieceType.BISHOP, new BoardPosition(0, 0), this.whitePlayer)).Build();

            IPieceMovementStrategies pms = new ClassicPieceMovementStrategies();

            Assert.True(pms.PieceMovementStrategy(board.GetPieceAtPosition(new BoardPosition(0,0))).GetPossibleMoves(board).Contains(new BoardPosition(7,7)));
            Assert.True(true);
        }
    }
}
