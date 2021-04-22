using Mazzoli.game;
using Mazzoli.player;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game.factory
{
    public interface IGameFactory
    {
        IGame Classic(IPlayerPair playerPair);

        IGame PawnHordeVariant(IPlayerPair playerPair);
    }
}