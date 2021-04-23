using Scolari.Boards;

namespace Scolari.Movement
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
