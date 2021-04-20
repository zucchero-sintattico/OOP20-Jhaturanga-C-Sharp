abstract class AbstractJavaFXView : BasicView, IJavaFXView
{
    public IStage Stage { get; set; }
    public abstract void Init();

}