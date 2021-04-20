class PieceFactory : IPieceFactory
{
    private IPlayer player;

    public PieceFactory(IPlayer player)
    {
        this.player = player;
    }
}