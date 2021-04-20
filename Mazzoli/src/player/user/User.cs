class User : IUser
{
    public string Username { get; }

    public User(string username)
    {
        this.Username = username;
    }

}