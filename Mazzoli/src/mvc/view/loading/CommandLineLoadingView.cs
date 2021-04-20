class CommandLineLoadingView : BasicView, ICommandLineView
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