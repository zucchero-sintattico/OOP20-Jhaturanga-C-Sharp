using Mazzoli.mvc.view;
using OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.util;

namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.view
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