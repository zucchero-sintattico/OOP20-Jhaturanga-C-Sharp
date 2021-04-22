using System.Collections.Generic;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user.builder;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.userstorage;

namespace OOP20_Jhaturanga_C_Sharp.Andruccioli.usermanager
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
