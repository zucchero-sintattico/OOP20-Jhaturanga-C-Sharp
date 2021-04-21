using Mazzoli.mvc.view.javafx;

namespace Mazzoli.mvc.view
{
    public interface IJavaFXView : IView
    {
        IStage Stage { get; set; }

        void Init();
    }
}