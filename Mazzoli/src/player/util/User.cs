namespace Mazzoli.player.util
{
    /// <summary>
    /// Basic implementation of the User interface.
    /// </summary>
    public class User : IUser
    {
        public string Username { get; }

        public User(string username)
        {
            this.Username = username;
        }

    }
}