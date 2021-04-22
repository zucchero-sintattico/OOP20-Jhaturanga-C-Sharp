using Jhaturanga_CSharp.Movement.MovementManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Board
{
    class StartingBoardFactory : IStartingBoardFactory
    {

        private static readonly int CLASSIC_BOARD_COLUMNS = 8;
        private static readonly int CLASSIC_BOARD_ROWS = 8;
        private static readonly int ONE_D_BOARD_COLUMNS = 1;
        private static readonly int ROWS_OF_PAWNS = 4;
        private static readonly int THREECOL_BOARD_COLUMNS = 3;

        private static readonly IDictionary<string, PieceType> letterToPieceType = new Dictionary<string, PieceType>() { { "k", PieceType.KING }, { "q", PieceType.QUEEN }, { "b",
        PieceType.BISHOP }, { "r", PieceType.ROOK }, { "p", PieceType.PAWN }, { "n", PieceType.KNIGHT } };

        private readonly Func<string, PieceType> FromLetterToPieceType = letter => letterToPieceType[letter.ToLower()];

        private IBoard FromStringToBoard(IPlayerPair players, string board, int columns, int rows)
        {
            IBoardBuilder boardBuilder = new BoardBuilder();

            var pieces = board.Split("/");

            foreach(string pieceId in pieces)
            {
                var splitted = pieceId.Split(",");

                string pieceName = splitted[0];
                int xPos = int.Parse(splitted[1]);
                int yPos = int.Parse(splitted[2]);

                boardBuilder.AddPiece(this.GetPieceFromComponents(players, pieceName, xPos, yPos));

            }

            return boardBuilder.Columns(columns).Rows(rows).Build();
        }

        private IPiece GetPieceFromComponents(IPlayerPair players, string letter, int x, int y)
        {
            return this.ChoosePlayerOwner(players, letter).PieceFactory.PieceFromPieceType(this.FromLetterToPieceType(letter), new BoardPosition(x, y));
        }

        private IPlayer ChoosePlayerOwner(IPlayerPair players, string letter)
        {
            return letter.ToUpper().Equals(letter) ? players.WhitePlayer : players.BlackPlayer;
        }

        public IBoard ClassicBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players,
                "R,0,0/N,1,0/B,2,0/Q,3,0/K,4,0/B,5,0/N,6,0/R,7,0/P,0,1/P,1,1/P,2,1/P,3,1/"
                        + "P,4,1/P,5,1/P,6,1/P,7,1/r,0,7/n,1,7/b,2,7/q,3,7/k,4,7/b,5,7/"
                        + "n,6,7/r,7,7/p,0,6/p,1,6/p,2,6/p,3,6/p,4,6/p,5,6/p,6,6/p,7,6",
                CLASSIC_BOARD_COLUMNS, CLASSIC_BOARD_ROWS);
        }

        public IBoard CustomizedBoard(string startingBoard, int columns, int rows, IPlayerPair players)
        {
            return this.FromStringToBoard(players, startingBoard, columns, rows);
        }

        public IBoard OneDimensionBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players, "K,0,0/N,0,1/R,0,2/k,0,7/n,0,6/r,0,5", ONE_D_BOARD_COLUMNS,
                CLASSIC_BOARD_ROWS);
        }

        public IBoard PawnHordeBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players,"K,4,4/r,0,7/n,1,7/b,2,7/q,3,7/k,4,7/b,5,7/n,6,7/r,7,7/p,0,6/p,1,6/p,2,6/p,3,6/p,4,6/p,5,6/p,6,6/p,7,6",
                CLASSIC_BOARD_COLUMNS, CLASSIC_BOARD_ROWS);
        }

        public IBoard ProblemFiveBoard(IPlayerPair players)
        {
            string completeBoard = "R,0,0/Q,3,0/K,4,0/R,7,0/" + "P,0,1/P,1,1/P,2,1/P,5,1/P,6,1/"
                + "N,2,2/P,3,2/" + "B,2,3/P,4,3/" + "b,2,4/n,3,4/p,4,4/N,6,4/" + "n,2,5/"
                + "p,0,6/p,1,6/p,2,6/p,5,6/p,6,6/" + "r,0,7/b,2,7/q,3,7/r,5,7/k,6,7";

            return this.FromStringToBoard(players, completeBoard, CLASSIC_BOARD_COLUMNS, CLASSIC_BOARD_ROWS);
        }

        public IBoard ProblemFourBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players,
                "K,0,7/Q,1,6/B,5,7/B,6,7/p,5,5/r,5,3/r,7,3/q,6,2/p,7,1/p,5,1/p,3,1/p,1,1/N,0,2/N,3,2/R,2,3/k,0,1/b,0,0",
                CLASSIC_BOARD_COLUMNS, CLASSIC_BOARD_ROWS);
        }

        public IBoard ProblemOneBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players, "R,6,7/K,5,3/Q,4,3/p,2,6/k,3,6", CLASSIC_BOARD_COLUMNS,
                CLASSIC_BOARD_ROWS);
        }

        public IBoard ProblemThreeBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players, "k,3,0/p,2,1/B,4,0/K,5,2/Q,7,7", CLASSIC_BOARD_COLUMNS,
                CLASSIC_BOARD_ROWS);
        }

        public IBoard ProblemTwoBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players, "P,3,6/K,5,7/k,7,7/p,7,6/n,7,5", CLASSIC_BOARD_COLUMNS,
                CLASSIC_BOARD_ROWS);
        }

        public IBoard ThreeColumnsBoard(IPlayerPair players)
        {
            return this.FromStringToBoard(players,
                "K,0,0/Q,1,0/N,2,0/P,0,1/P,1,1/P,2,1/k,0,7/q,1,7/n,2,7/p,0,6/p,1,6/p,2,6", THREECOL_BOARD_COLUMNS,
                CLASSIC_BOARD_ROWS);
        }
    }
}
