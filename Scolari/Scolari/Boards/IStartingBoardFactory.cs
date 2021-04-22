using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp.Boards
{
    public interface IStartingBoardFactory
    {

        IBoard ClassicBoard(IPlayerPair players);

        IBoard PawnHordeBoard(IPlayerPair players);

        IBoard ThreeColumnsBoard(IPlayerPair players);

        IBoard OneDimensionBoard(IPlayerPair players);

        IBoard CustomizedBoard(string startingBoard, int columns, int rows, IPlayerPair players);

        IBoard ProblemOneBoard(IPlayerPair players);

        IBoard ProblemTwoBoard(IPlayerPair players);


        IBoard ProblemThreeBoard(IPlayerPair players);


        IBoard ProblemFourBoard(IPlayerPair players);


        IBoard ProblemFiveBoard(IPlayerPair players);
    }
}
