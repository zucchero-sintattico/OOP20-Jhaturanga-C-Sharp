using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp
{
    public interface IBasicMovement
    {
        /// <summary>
        /// the position of the wanted destination for the Piece
        /// </summary>
        IBoardPosition Origin { get; }

        /// <summary>
        /// the position of the starting position of the Piece in this movement
        /// </summary>
        IBoardPosition Destination { get; }

    }
}
