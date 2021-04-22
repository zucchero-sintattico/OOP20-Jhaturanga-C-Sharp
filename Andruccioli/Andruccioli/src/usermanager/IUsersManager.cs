using OOP20.user;
using System.Collections.Generic;

namespace OOP20.usermanager
{
    public interface IUsersManager
    {
        /// <param name="username">username to login</param>
        /// <param name="password">password to login</param>
        /// <returns>the logged User, if present</returns>
        IUser? Login(string username, string password);

        /// <param name="username">username to register</param>
        /// <param name="password">password to register</param>
        /// <returns>the registered User, if possible</returns>
        IUser? Register(string username, string password);

        /// <param name="user">User to put</param>
        /// <returns>the User put, if possible</returns>
        IUser? Put(IUser user);

        /// <returns>all the Users</returns>
        ISet<IUser> AllUsers { get; }
    }
}
