using OOP20.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20.userstorage
{
    public interface IUserDataStorageStrategy
    {
        /// <param name="username">username to search in the storage</param>
        /// <returns>true if present</returns>
        bool IsPresent(string username);

        /// <param name="username">username to get the User from the storage</param>
        /// <returns>the User if present</returns>
        IUser? this[string username] { get; }

        /// <summary>
        /// the Set of all Users in the storage
        /// </summary>
        ISet<IUser> Users { get; }

        /// <param name="user">user to put in storage</param>
        void Put(IUser user);
    }
}
