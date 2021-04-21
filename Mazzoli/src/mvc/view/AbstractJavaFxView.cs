using Mazzoli.mvc.view.javafx;

namespace Mazzoli.mvc.view
{
    public abstract class AbstractJavaFXView : BasicView, IJavaFXView
    {
        public IStage Stage { get; set; }
        public abstract void Init();

    }
}