using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller.loading;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view.loading
{
    /// <summary>
    /// The View where the application data is loaded.
    /// </summary>
    public class LoadingView : AbstractJavaFxView
    {
        public override void Init()
        {
            this.GetLoadingController().Load();
        }

        /// <summary>
        /// Get the LoadingController.
        /// </summary>
        /// <returns>The loading controller</returns>
        private ILoadingController GetLoadingController()
        {
            return (ILoadingController)this.Controller;
        }
    }
}