using Mazzoli.mvc.controller;

namespace Mazzoli.mvc.view
{
    /// <summary>
    /// The generic template for a View.
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// The controller of the view.
        /// </summary>
        IController Controller { get; set; }
    }
}