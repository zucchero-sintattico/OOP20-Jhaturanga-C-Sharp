class ApplicationInstance : IModel
{
    public IUser FirstUser { get; set; }
    public IUser SecondUser { get; set; }
    public IMatch Match { get; set; }
    public IReplay Replay { get; set; }

}