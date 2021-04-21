using Mazzoli.match;
using Mazzoli.player.user;
using Mazzoli.replay;

interface IModel
{
    IUser FirstUser { get; set; }
    IUser SecondUser { get; set; }
    IMatch Match { get; set; }
    IReplay Replay { get; set; }
}