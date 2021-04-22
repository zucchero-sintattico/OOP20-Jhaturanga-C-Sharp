using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement
{
    public interface IPieceMovementStrategies
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="piece"></param>
        /// <returns></returns>
        IMovementStrategy PieceMovementStrategy(IPiece piece);
    }
}
