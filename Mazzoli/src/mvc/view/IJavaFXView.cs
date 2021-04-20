interface IJavaFXView : IView
{
    IStage Stage { get; set; }

    void Init();
}