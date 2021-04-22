using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp.Boards
{
    public interface IStartingBoardFactory
    {
        /// <summary>
        /// Use this method to get a starting classic Board
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard ClassicBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get a starting pawn horde Board
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard PawnHordeBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get a starting three columns Board
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard ThreeColumnsBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get a starting Board to play 1D chess
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard OneDimensionBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get a customized Board
        /// </summary>
        /// <param name="startingBoard">the starting board wanted</param>
        /// <param name="columns">number of columns of the custom starting board</param>
        /// <param name="rows">the number of rows of the custom starting board</param>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard CustomizedBoard(string startingBoard, int columns, int rows, IPlayerPair players);

        /// <summary>
        /// Use this method to get the starting board for the problem 1.
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns>Board representing the starting board wanted</returns>
        IBoard ProblemOneBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get the starting board for the problem 2.
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns></returns>
        IBoard ProblemTwoBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get the starting board for the problem 3.
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns></returns>
        IBoard ProblemThreeBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get the starting board for the problem 4.
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns></returns>
        IBoard ProblemFourBoard(IPlayerPair players);

        /// <summary>
        /// Use this method to get the starting board for the problem 5.
        /// </summary>
        /// <param name="players">The players participating</param>
        /// <returns></returns>
        IBoard ProblemFiveBoard(IPlayerPair players);
    }
}
