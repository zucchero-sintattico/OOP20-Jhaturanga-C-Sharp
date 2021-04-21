namespace Mazzoli.player.user
{
    public class User : IUser
    {
        public string Username { get; }

        public User(string username)
        {
            this.Username = username;
        }

    }
}