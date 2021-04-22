using OOP20.user;
using OOP20.usermanager;
using OOP20.userstorage;
using System;
using System.Collections.Generic;

namespace OOP20
{
    class Program
    {
        static void Main(string[] args)
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            
        }
    }
}
