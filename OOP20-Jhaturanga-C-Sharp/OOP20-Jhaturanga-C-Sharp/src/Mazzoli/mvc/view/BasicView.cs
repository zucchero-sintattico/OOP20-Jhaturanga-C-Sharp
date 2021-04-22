using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view
{
    /// <summary>
    /// Basic implementation of the interface View.
    /// </summary>
    public class BasicView : IView
    {
        public IController Controller { get; set; }
    }
}