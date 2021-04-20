interface IModel
{
    IUser FirstUser { get; set; }
    IUser SecondUser { get; set; }
    IMatch Match { get; set; }
    IReplay Replay { get; set; }
}