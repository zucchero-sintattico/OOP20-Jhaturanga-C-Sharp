using Scolari.Boards;
using Scolari.Util;

namespace Scolari.Movement.MovementManaging
{
    public interface IGameController
    {
        /// <summary>
        /// Get the actual game status
        /// </summary>
        /// <param name="playerTurn">The Player who's turn it is. We in fact need to know 
        /// who's turn it is to determine the outcome of certainsituations such as draw conditions</param>
        /// <returns>The situation of the match</returns>
        GameStatus GetGameStatus(IPlayer playerTurn);

        /// <summary>
        /// Control if the king is under check
        /// </summary>
        /// <param name="player">is the player of which to check if the move puts his king in a check state</param>
        /// <returns>true if the king is under check</returns>
        bool IsInCheck(IPlayer player);

        /// <summary>
        /// Control if the king is under check
        /// </summary>
        /// <param name="movement">the movement to test whether it wouldn't put the executing player in check</param>
        /// <returns>true if the movement wouldn't result in a check by the same player who executed the movement</returns>
        bool WouldNotBeInCheck(IPieceMovement movement);

        /// <summary>
        /// Return a boolean that states if the player passed as parameter won the game
        /// </summary>
        /// <param name="player">player is the player of which check if he won the game</param>
        /// <returns>true if player won false otherwise</returns>
        bool IsWinner(IPlayer player);

        /// <summary>
        /// Return the state of the Board
        /// </summary>
        /// <returns>IBoard representing the actual state of the board of the match</returns>
        IBoard GetBoard();

        /// <summary>
        /// Return the list of the players
        /// </summary>
        /// <returns>PlayerPair representing the players of the game</returns>
        IPlayerPair GetPlayers();

        /// <summary>
        /// Return the PieceMovementStrategyFactory of the match's GameType that's been controlled
        /// </summary>
        /// <returns>PieceMovementStrategyFactory representing the PieceMovementStrategyFactory of the game</returns>
        IPieceMovementStrategies GetPieceMovementStrategies();
    }
}
