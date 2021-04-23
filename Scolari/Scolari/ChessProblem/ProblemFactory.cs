using System.Collections.Generic;
using Scolari.Boards;
using Scolari.Movement;
using Scolari.Movement.MovementManaging;
using Scolari.Util;

namespace Scolari.ChessProblem
{
    public class ProblemFactory : IProblemFactory
    {

        private static IList<IBasicMovement> GenerateMovementsFromString(string movements)
        {

            IList<IBasicMovement> possibleDestinations = new List<IBasicMovement>();

            var movs = movements.Split("/");

            foreach(string origDest in movs)
            {
                var positions = origDest.Split(",");

                var orig = positions[0];
                var dest = positions[1];

                var origCoordinatesXY = orig.Split("-");
                var destCoordinatesXY = dest.Split("-");

                var origX = int.Parse(origCoordinatesXY[0]);
                var origY = int.Parse(origCoordinatesXY[1]);
                var destX = int.Parse(destCoordinatesXY[0]);
                var destY = int.Parse(destCoordinatesXY[1]);

                possibleDestinations.Add(new BasicMovement(new BoardPosition(origX, origY), new BoardPosition(destX, destY)));

            }
            return possibleDestinations;
        }

        public IProblem ProblemFive(IPlayerPair players)
        {
            return new Problem(GenerateMovementsFromString("7-0,7-7/6-7,7-7/3-0,7-4/7-7,6-7/7-4,7-6"), new StartingBoardFactory().ProblemFiveBoard(players));
        }

        public IProblem ProblemFour(IPlayerPair players)
        {
            return new Problem(GenerateMovementsFromString("1-6,5-2/6-2,5-2/2-3,4-3"), new StartingBoardFactory().ProblemFourBoard(players));
        }

        public IProblem ProblemOne(IPlayerPair players)
        {
            return new Problem(GenerateMovementsFromString("5-3,4-4/3-6,4-6/4-3,7-6"), new StartingBoardFactory().ProblemOneBoard(players));
        }

        public IProblem ProblemThree(IPlayerPair players)
        {
            return new Problem(GenerateMovementsFromString("7-7,1-1/3-0,4-0/1-1,2-0"), new StartingBoardFactory().ProblemThreeBoard(players));
        }

        public IProblem ProblemTwo(IPlayerPair players)
        {
            return new Problem(GenerateMovementsFromString("3-6,3-7/7-5,5-6/5-7,5-6"), new StartingBoardFactory().ProblemTwoBoard(players));
        }
    }
}
