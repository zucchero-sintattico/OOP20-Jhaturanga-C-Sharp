using Mazzoli.mvc.model;
using Mazzoli.mvc.view;

namespace Mazzoli.mvc.controller
{
    public interface IController
    {
        IModel Model { get; set; }

        IView View { get; set; }

    }
}