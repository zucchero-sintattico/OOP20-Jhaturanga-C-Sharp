using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp
{
    public interface IPieceMovement : IBasicMovement 
    {
        /// <summary>
        /// 
        /// </summary>
        IPiece PieceInvolved { get; }

        /// <summary>
        /// 
        /// </summary>
        void Execute();


    }
}
