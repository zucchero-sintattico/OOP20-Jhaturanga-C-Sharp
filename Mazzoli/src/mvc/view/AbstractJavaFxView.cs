using Mazzoli.mvc.util;

namespace Mazzoli.mvc.view
{
    /// <summary>
    /// Basic abstract implementation of the JavaFX view.
    /// </summary>
    public abstract class AbstractJavaFxView : BasicView, IJavaFxView
    {
        public IStage Stage { get; set; }
        public abstract void Init();

    }
}