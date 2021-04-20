using System.Collections.Generic;
static class GameTypeExtension
{
    delegate IGame GameGenerationStrategy(IGameFactory gameFactory, IPlayerPair playerPair);

    private static Dictionary<GameType, string> nameMapper;
    private static Dictionary<GameType, string> descriptionMapper;
    private static Dictionary<GameType, GameGenerationStrategy> gameGenerationStrategyMapper;

    private static IGameFactory gameFactory = new GameFactory();

    static GameTypeExtension()
    {
        nameMapper = new Dictionary<GameType, string>()
        {
            {GameType.CLASSIC, "Classic"},
            {GameType.PAWN_HORDE, "Pawn Horde Variant"}
        };

        descriptionMapper = new Dictionary<GameType, string>(){
            {GameType.CLASSIC, "The classic chess game"},
            {GameType.PAWN_HORDE, "The white player has an horde of pawns"}
        };

        gameGenerationStrategyMapper = new Dictionary<GameType, GameGenerationStrategy>(){
            {GameType.CLASSIC, (gameFactory, playerPair) => gameFactory.Classic(playerPair)},
            {GameType.PAWN_HORDE, (gameFactory, playerPair) => gameFactory.PawnHordeVariant(playerPair)}
        };
    }

    public static string GetName(this GameType type) => nameMapper.GetValueOrDefault(type);


    public static string GetDescription(this GameType type) => descriptionMapper.GetValueOrDefault(type);


    public static IGame GetNewGameInstance(this GameType type, IPlayerPair playerPair) =>
         gameGenerationStrategyMapper.GetValueOrDefault(type).Invoke(gameFactory, playerPair);

}