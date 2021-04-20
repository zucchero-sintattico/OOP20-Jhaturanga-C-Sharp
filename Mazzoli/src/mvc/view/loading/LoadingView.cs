class LoadingView : AbstractJavaFXView
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