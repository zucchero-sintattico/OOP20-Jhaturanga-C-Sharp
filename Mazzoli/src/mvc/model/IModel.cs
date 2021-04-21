using Mazzoli.match;
using Mazzoli.player.util;
using Mazzoli.replay;

namespace Mazzoli.mvc.model
{
    public interface IModel
    {
        IUser FirstUser { get; set; }
        IUser SecondUser { get; set; }
        IMatch Match { get; set; }
        IReplay Replay { get; set; }
    }
}