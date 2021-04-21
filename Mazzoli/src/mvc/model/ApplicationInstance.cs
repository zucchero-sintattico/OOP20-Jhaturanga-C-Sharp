using Mazzoli.match;
using Mazzoli.player.util;
using Mazzoli.replay;

namespace Mazzoli.mvc.model
{
    public class ApplicationInstance : IModel
    {
        public IUser FirstUser { get; set; }
        public IUser SecondUser { get; set; }
        public IMatch Match { get; set; }
        public IReplay Replay { get; set; }

    }
}