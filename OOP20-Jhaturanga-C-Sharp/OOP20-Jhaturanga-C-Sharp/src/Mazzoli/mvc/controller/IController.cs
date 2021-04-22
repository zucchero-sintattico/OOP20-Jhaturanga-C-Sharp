using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.model;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller
{
    /// <summary>
    /// The generic template for a Controller.
    /// </summary>
    public interface IController
    {
        /// <summary>
        /// The Model access.
        /// </summary>
        IModel Model { get; set; }

        /// <summary>
        /// The View access.
        /// </summary>
        IView View { get; set; }

    }
}