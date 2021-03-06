using Mazzoli.mvc.util;
using Mazzoli.player.util;

namespace Mazzoli.mvc.model
{
    /// <summary>
    /// The Model access. It save the actual state of the application, including the
    /// logged users, the actual match and the actual replay.
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// The first logged user.
        /// </summary>
        IUser FirstUser { get; set; }
        
        /// <summary>
        /// The second logged user.
        /// </summary>
        IUser SecondUser { get; set; }
        
        /// <summary>
        /// The actual match.
        /// </summary>
        IMatch Match { get; set; }
        
        /// <summary>
        /// The actual replay.
        /// </summary>
        IReplay Replay { get; set; }
    }
}