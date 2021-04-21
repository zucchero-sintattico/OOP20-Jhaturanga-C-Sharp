using Mazzoli.game;
using Mazzoli.player;

namespace Mazzoli.game.factory
{
    public interface IGameFactory
    {
        IGame Classic(IPlayerPair playerPair);

        IGame PawnHordeVariant(IPlayerPair playerPair);
    }
}