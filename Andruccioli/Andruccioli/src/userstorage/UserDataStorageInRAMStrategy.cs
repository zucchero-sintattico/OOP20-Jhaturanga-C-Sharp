using OOP20.user;
using System.Collections.Generic;


namespace OOP20.userstorage
{
    /// <summary>
    /// This implementation does not save data in the persistent memory,
    /// it's a simply class that store the data in a Dictionary.
    /// When the program is closed, the data are erased.
    /// </summary>
    public sealed class UserDataStorageInRAMStrategy : IUserDataStorageStrategy
    {
        private readonly IDictionary<string, IUser> users = new Dictionary<string, IUser>();

        public IUser? this[string username] => IsPresent(username) ? this.users[username] : null;

        public ISet<IUser> Users => new HashSet<IUser>(this.users.Values);

        public bool IsPresent(string username) => this.users.ContainsKey(username);

        public void Put(IUser user) => this.users[user.Username] = user;
    }
}
