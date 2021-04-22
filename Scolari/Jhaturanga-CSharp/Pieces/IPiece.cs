using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp
{
    public interface IPiece
    {

        /// <summary>
        /// 
        /// </summary>
        string Identifier { get; }
        
        /// <summary>
        /// 
        /// </summary>
        PieceType Type { get; }

        /// <summary>
        /// 
        /// </summary>
        IBoardPosition PiecePosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IPlayer Player { get; }

        /// <summary>
        /// 
        /// </summary>
        bool HasMoved { get; set; }

    }
}
