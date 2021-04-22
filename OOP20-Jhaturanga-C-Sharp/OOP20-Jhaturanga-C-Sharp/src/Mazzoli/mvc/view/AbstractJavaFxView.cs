using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.util;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view
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