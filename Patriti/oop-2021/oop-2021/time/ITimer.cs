using System;
namespace oop_2021.time
{
public interface ITimer
{

    double GetRemaningTime(IPlayer player);

    /**
        * <summary>starts the timer for the selected player.</summary>
        * 
        * <param name="player"> which you want starting time </param>
        */
    void Start(IPlayer player);

    /**
        * 
        * <summary>stop all timer's players.</summary>
        */
    void Stop();

    /**
        * <summary>it returns false only if no timer of any player is active, else true.</summary>
        * 
        * <returns>timer status</returns>
        */
    bool IsRunning();

    /**
        * <summary>stop the timer of the current player, and start the timer of the selected
        * player.</summary>
        * 
        * <param name="player">  change the turn on player timer </param>
        */
    void SwitchPlayer(IPlayer player);



}
}
