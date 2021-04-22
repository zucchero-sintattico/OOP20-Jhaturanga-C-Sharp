using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.model;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller
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