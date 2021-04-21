using Mazzoli.mvc.controller;

namespace Mazzoli.mvc.view
{
    /// <summary>
    /// Basic implementation of the interface View.
    /// </summary>
    public class BasicView : IView
    {
        public IController Controller { get; set; }
    }
}