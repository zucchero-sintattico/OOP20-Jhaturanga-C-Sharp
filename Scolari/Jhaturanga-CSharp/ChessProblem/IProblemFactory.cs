using System;
using System.Collections.Generic;
using System.Text;
using Jhaturanga_CSharp.Movement.MovementManaging;

namespace Jhaturanga_CSharp.ChessProblem
{
    public interface IProblemFactory
    {
        IProblem ProblemOne(IPlayerPair players);
        IProblem ProblemTwo(IPlayerPair players);
        IProblem ProblemThree(IPlayerPair players);
        IProblem ProblemFour(IPlayerPair players);
        IProblem ProblemFive(IPlayerPair players);
    }
}
