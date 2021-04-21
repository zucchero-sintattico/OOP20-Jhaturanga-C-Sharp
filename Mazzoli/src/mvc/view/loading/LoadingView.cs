using Mazzoli.mvc.controller.loading;

namespace Mazzoli.mvc.view.loading
{
    public class LoadingView : AbstractJavaFXView
    {
        public override void Init()
        {
            this.GetLoadingController().Load();
        }

        private ILoadingController GetLoadingController()
        {
            return (ILoadingController)this.Controller;
        }
    }
}