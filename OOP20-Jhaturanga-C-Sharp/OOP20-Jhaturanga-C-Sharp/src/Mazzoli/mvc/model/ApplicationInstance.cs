using Mazzoli.player.util;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.util;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.model
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