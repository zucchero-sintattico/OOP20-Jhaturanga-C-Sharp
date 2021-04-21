namespace Mazzoli.mvc.view
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