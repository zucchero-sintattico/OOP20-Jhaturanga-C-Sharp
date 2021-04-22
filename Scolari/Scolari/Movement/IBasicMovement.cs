using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Board;

namespace Jhaturanga_CSharp
{
    public interface IBasicMovement
    {
        /// <summary>
        /// 
        /// </summary>
        IBoardPosition Origin { get; }

        /// <summary>
        /// 
        /// </summary>
        IBoardPosition Destination { get; }

    }
}
