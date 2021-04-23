using Scolari.Pieces;

namespace Scolari.Movement
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
