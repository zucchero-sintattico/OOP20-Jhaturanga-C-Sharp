using Mazzoli.mvc.controller.loading;

namespace Mazzoli.mvc.view.loading
{
    public class CommandLineLoadingView : BasicView, ICommandLineView
    {
        public void Run()
        {
            this.GetLoadingController().Load();
        }

        private ILoadingController GetLoadingController()
        {
            return (ILoadingController)this.Controller;
        }
    }
}