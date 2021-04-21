using Mazzoli.mvc.util;
using Mazzoli.player.util;

namespace Mazzoli.mvc.model
{
    /// <summary>
    /// Implementation of the IModel interface.
    /// </summary>
    public class ApplicationInstance : IModel
    {
        public IUser FirstUser { get; set; }
        public IUser SecondUser { get; set; }
        public IMatch Match { get; set; }
        public IReplay Replay { get; set; }

    }
}