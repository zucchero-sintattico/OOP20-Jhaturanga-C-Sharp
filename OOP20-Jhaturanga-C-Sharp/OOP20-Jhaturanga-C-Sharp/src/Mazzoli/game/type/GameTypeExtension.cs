using System.Collections.Generic;
using Mazzoli.game;
using Mazzoli.player;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.game.factory;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.player;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.game.type
{
    /// <summary>
    /// The extension methods for the GameType enum
    /// </summary>
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
                {GameType.Classic, "Classic"},
                {GameType.PawnHorde, "Pawn Horde Variant"}
            };

            DescriptionMapper = new Dictionary<GameType, string>()
            {
                {GameType.Classic, "The classic chess game"},
                {GameType.PawnHorde, "The white player has an horde of pawns"}
            };

            GameGenerationStrategyMapper = new Dictionary<GameType, GameGenerationStrategy>()
            {
                {GameType.Classic, (gameFactory, playerPair) => gameFactory.Classic(playerPair)},
                {GameType.PawnHorde, (gameFactory, playerPair) => gameFactory.PawnHordeVariant(playerPair)}
            };
        }

        public static string GetName(this GameType type) => NameMapper[type];


        public static string GetDescription(this GameType type) => DescriptionMapper[type];


        public static IGame GetNewGameInstance(this GameType type, IPlayerPair playerPair) =>
            GameGenerationStrategyMapper[type].Invoke(GameFactory, playerPair);
        
    }
}