using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Boards
{

    interface IBoardBuilder
    {
        /// <summary>
        /// Used to set the columns numbers of the board to create
        /// </summary>
        /// <param name="rows">the number of rows of the board</param>
        /// <returns>itself</returns>
        IBoardBuilder Rows(int rows);

        /// <summary>
        /// Used to set the columns numbers of the board to create
        /// </summary>
        /// <param name="columns">the number of columns of the board</param>
        /// <returns>itself</returns>
        IBoardBuilder Columns(int columns);

        /// <summary>
        /// Used to gradually add pieces to the starting board
        /// </summary>
        /// <param name="piece">the piece to add to the starting board</param>
        /// <returns>itself</returns>
        IBoardBuilder AddPiece(IPiece piece);

        /// <summary>
        /// Use this method to create the board.
        /// </summary>
        /// <returns>Board built</returns>
        IBoard Build();
    }
}
