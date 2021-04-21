using Mazzoli.mvc.model;
using Mazzoli.mvc.view;

namespace Mazzoli.mvc.controller
{
    public class BasicController : IController
    {
        public IModel Model { get; set; }

        public IView View { get; set; }

    }
}