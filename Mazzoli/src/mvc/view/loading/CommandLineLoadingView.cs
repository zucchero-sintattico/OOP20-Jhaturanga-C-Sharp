using Mazzoli.mvc.controller.loading;

namespace Mazzoli.mvc.view.loading
{
    /// <summary>
    /// Command line version of the Loading View
    /// </summary>
    public class CommandLineLoadingView : BasicView, ICommandLineView
    {
        public void Run()
        {
            this.GetLoadingController().Load();
        }

        /// <summary>
        /// Get the loading controller.
        /// </summary>
        /// <returns>The loading controller</returns>
        private ILoadingController GetLoadingController()
        {
            return (ILoadingController)this.Controller;
        }
    }
}