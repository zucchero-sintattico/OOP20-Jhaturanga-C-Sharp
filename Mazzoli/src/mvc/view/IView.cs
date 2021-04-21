using Mazzoli.mvc.controller;

namespace Mazzoli.mvc.view
{
    public interface IView
    {
        IController Controller { get; set; }
    }
}