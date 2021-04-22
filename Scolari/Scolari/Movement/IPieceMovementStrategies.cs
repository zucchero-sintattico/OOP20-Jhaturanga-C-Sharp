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
        /// <param name="piece">the piece of which we want to have it's MovementStrategy</param>
        /// <returns>the PieceMovementStrategy of the passed piece</returns>
        IMovementStrategy PieceMovementStrategy(IPiece piece);
    }
}
