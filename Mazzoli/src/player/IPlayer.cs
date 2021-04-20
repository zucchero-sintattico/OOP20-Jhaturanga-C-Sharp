interface IPlayer
{
    PlayerColor Color { get; }
    IUser User { get; }
    IPieceFactory PieceFactory { get; }


}