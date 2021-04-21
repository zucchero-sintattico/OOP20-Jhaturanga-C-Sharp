using System.Collections.Generic;
using Mazzoli.game.factory;
using Mazzoli.game.movementmanager;
using Mazzoli.player;

namespace Mazzoli.game.type
{
    public static class GameTypeExtension
    {
        private delegate IGame GameGenerationStrategy(IGameFactory gameFactory, IPlayerPair playerPair);

        private static readonly Dictionary<GameType, string> NameMapper;
        private static readonly Dictionary<GameType, string> DescriptionMapper;
        private static readonly Dictionary<GameType, GameGenerationStrategy> GameGenerationStrategyMapper;

        private static readonly IGameFactory GameFactory = new GameFactory();

        static GameTypeExtension()
        {
            NameMapper = new Dictionary<GameType, string>()
            {
                {GameType.CLASSIC, "Classic"},
                {GameType.PAWN_HORDE, "Pawn Horde Variant"}
            };

            DescriptionMapper = new Dictionary<GameType, string>()
            {
                {GameType.CLASSIC, "The classic chess game"},
                {GameType.PAWN_HORDE, "The white player has an horde of pawns"}
            };

            GameGenerationStrategyMapper = new Dictionary<GameType, GameGenerationStrategy>()
            {
                {GameType.CLASSIC, (gameFactory, playerPair) => gameFactory.Classic(playerPair)},
                {GameType.PAWN_HORDE, (gameFactory, playerPair) => gameFactory.PawnHordeVariant(playerPair)}
            };
        }

        public static string GetName(this GameType type) => NameMapper.GetValueOrDefault(type);


        public static string GetDescription(this GameType type) => DescriptionMapper.GetValueOrDefault(type);


        public static IGame GetNewGameInstance(this GameType type, IPlayerPair playerPair) =>
            GameGenerationStrategyMapper.GetValueOrDefault(type)?.Invoke(GameFactory, playerPair);
        
    }
}