using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller.loading;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view;

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