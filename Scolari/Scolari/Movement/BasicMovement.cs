using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Boards;

namespace Jhaturanga_CSharp
{
    class BasicMovement : IBasicMovement
    {
        public IBoardPosition Origin { get; }

        public IBoardPosition Destination { get; }

        public BasicMovement(IBoardPosition origin, IBoardPosition destination)
        {
            this.Origin = origin;
            this.Destination = destination;
        }

    }
}
