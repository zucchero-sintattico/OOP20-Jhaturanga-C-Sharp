using Mazzoli.mvc.model;
using Mazzoli.mvc.view;

namespace Mazzoli.mvc.controller
{
    /// <summary>
    /// A basic implementation of a Controller. This is used for view which doesn't
    /// need access to model and as a superclass of other controllers.
    /// </summary>
    public class BasicController : IController
    {
        public IModel Model { get; set; }

        public IView View { get; set; }

    }
}