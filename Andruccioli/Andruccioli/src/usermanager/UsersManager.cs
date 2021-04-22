using OOP20.user;
using OOP20.userstorage;
using System.Collections.Generic;

namespace OOP20.usermanager
{
    public sealed class UsersManager : IUsersManager
    {
        private readonly IUserDataStorageStrategy dataStorage;

        public UsersManager(IUserDataStorageStrategy dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        public IUser? Login(string username, string password) =>
            this.dataStorage[username]?.HashedPassword == password ? this.dataStorage[username] : null;
        

        public IUser? Register(string username, string password)
        {
            if (this.dataStorage.IsPresent(username))
            {
                return null;
            }
            this.dataStorage.Put(new UserBuilder().Username(username).HashedPassword(password).Build());

            return this.dataStorage[username];
        }

        public IUser? Put(IUser user)
        {
            this.dataStorage.Put(user);
            return this.dataStorage[user.Username];
        }

        public ISet<IUser> AllUsers => this.dataStorage.Users;
    }
}
