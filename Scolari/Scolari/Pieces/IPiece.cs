using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp
{
    public interface IPiece
    {

        /// <summary>
        /// the unique name of this piece, it can be seen as an ID for the Piece
        /// </summary>
        string Identifier { get; }

        /// <summary>
        /// the name of the type of this Piece
        /// </summary>
        PieceType Type { get; }

        /// <summary>
        /// the actual Piece's position on the board
        /// </summary>
        IBoardPosition PiecePosition { get; set; }

        /// <summary>
        /// the actual Piece's Player owner
        /// </summary>
        IPlayer Player { get; }

        /// <summary>
        /// Get if the piece was moved or not
        /// </summary>
        bool HasMoved { get; set; }

    }
}
