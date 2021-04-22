using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Boards
{
    public interface IBoardPosition
    {
        /// <summary>
        /// Use this method to return the X position
        /// </summary>
        int X { get; }
        /// <summary>
        /// Use this method to return the Y position
        /// </summary>
        int Y { get; }
    }
}
