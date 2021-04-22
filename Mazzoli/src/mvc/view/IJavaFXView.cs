using Mazzoli.mvc.util;

namespace Mazzoli.mvc.view
{
    /// <summary>
    /// The template for a view used by JavaFX.
    /// </summary>
    public interface IJavaFxView : IView
    {
        /// <summary>
        /// The Stage component.
        /// </summary>
        IStage Stage { get; set; }

        /// <summary>
        /// The initialize method.
        /// </summary>
        void Init();
    }
}