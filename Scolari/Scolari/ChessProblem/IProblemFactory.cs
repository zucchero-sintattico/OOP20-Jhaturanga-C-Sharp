using Scolari.Movement.MovementManaging;
using Scolari.Util;

namespace Scolari.ChessProblem
{
    public interface IProblemFactory
    {
        /// <summary>
        /// the First chessProblem required
        /// </summary>
        /// <param name="players">The players participating to the chess problem</param>
        /// <returns></returns>
        IProblem ProblemOne(IPlayerPair players);
        /// <summary>
        /// the Second chessProblem required
        /// </summary>
        /// <param name="players">The players participating to the chess problem</param>
        /// <returns></returns>
        IProblem ProblemTwo(IPlayerPair players);
        /// <summary>
        /// the Third chessProblem required
        /// </summary>
        /// <param name="players">The players participating to the chess problem</param>
        /// <returns></returns>
        IProblem ProblemThree(IPlayerPair players);
        /// <summary>
        /// the Fourth chessProblem required
        /// </summary>
        /// <param name="players">The players participating to the chess problem</param>
        /// <returns></returns>
        IProblem ProblemFour(IPlayerPair players);
        /// <summary>
        /// the Fifth chessProblem required
        /// </summary>
        /// <param name="players">The players participating to the chess problem</param>
        /// <returns></returns>
        IProblem ProblemFive(IPlayerPair players);
    }
}
