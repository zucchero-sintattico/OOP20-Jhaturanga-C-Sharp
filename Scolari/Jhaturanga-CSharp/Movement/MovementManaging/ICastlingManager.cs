using System;
using System.Collections.Generic;
using System.Text;

namespace Jhaturanga_CSharp.Movement.MovementManaging
{
    public interface ICastlingManager
    {
        void CheckAndExecuteCastling(IPieceMovement movement);

        bool IsCastlingFullyCorrect(IPieceMovement movement);

        bool MightItBeCastle(IPieceMovement movement);
    }
}
