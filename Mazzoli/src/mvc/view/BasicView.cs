using Mazzoli.mvc.controller;

namespace Mazzoli.mvc.view
{
    public class BasicView : IView
    {
        public IController Controller { get; set; }
    }
}