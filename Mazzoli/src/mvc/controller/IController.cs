using Mazzoli.mvc.model;
using Mazzoli.mvc.view;

namespace Mazzoli.mvc.controller
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