using Mazzoli.mvc.view;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view
{
    /// <summary>
    /// The template for a command line view.
    /// </summary>
    public interface ICommandLineView : IView
    {
        /// <summary>
        /// Starts the view loop
        /// </summary>
        void Run();
    }
}