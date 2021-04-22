using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp
{
    public interface IPieceMovement : IBasicMovement 
    {
        /// <summary>
        /// the Piece involved
        /// </summary>
        IPiece PieceInvolved { get; }

        /// <summary>
        /// Executes the movement itself
        /// </summary>
        void Execute();


    }
}
