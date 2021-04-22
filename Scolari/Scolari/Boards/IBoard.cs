using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Boards
{
    public interface IBoard
    {
        /// <summary>
        /// Used to get the columns of the Board
        /// </summary>
        int Columns { get; }

        /// <summary>
        /// Used to get the rows of the Board
        /// </summary>
        int Rows { get; }

        /// <summary>
        /// Get all the piece on the board
        /// </summary>
        /// <returns>the pieces</returns>
        ISet<IPiece> GetPieces();

        /// <summary>
        /// Get the piece in the specified position
        /// </summary>
        /// <param name="boardPosition">the position to check</param>
        /// <returns>the piece in the specified position if present, null otherwise</returns>
        IPiece GetPieceAtPosition(IBoardPosition boardPosition);

        /// <summary>
        /// Given a BoardPosition it let's you know if it is contained or not in the Board currently used
        /// </summary>
        /// <param name="positionToCheck">The position at which verify</param>
        /// <returns>true if the position is contained, false otherwise</returns>
        bool Contains(IBoardPosition positionToCheck);

        /// <summary>
        /// Given a Piece it let's you know if it is contained or not in the Board
        /// </summary>
        /// <param name="pieceToCheck">the piece to check if present on the board</param>
        /// <returns>true if the piece is contained, false otherwise</returns>
        bool Contains(IPiece pieceToCheck);

        /// <summary>
        /// Given a BoardPosition it let's you remove a Piece at that position
        /// </summary>
        /// <param name="positionToRemove">the position where to remove a piece if present</param>
        /// <returns>true if the position had a Piece in it and was then removed, false if the piece is not present</returns>
        bool RemoveAtPosition(IBoardPosition positionToRemove);

        /// <summary>
        /// Given a Piece it let's you remove it from the Board
        /// </summary>
        /// <param name="pieceToRemove">the piece we want to remove</param>
        /// <returns>true if the Piece is in the Board and was then removed, false otherwise</returns>
        bool Remove(IPiece pieceToRemove);

        /// <summary>
        /// Add a piece to the board
        /// </summary>
        /// <param name="pieceToAdd">the piece to be added</param>
        /// <returns>true if the position didn't have a Piece in it and the Piece given as parameter was then added</returns>
        bool Add(IPiece pieceToAdd);

    }
}
