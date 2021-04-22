using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.usermanager;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.userstorage;

namespace OOP20_Jhaturanga_C_Sharp.test.Andruccioli
{
    public class UserManagerTest
    {
        [Test]
        public void NormalUsingTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            IUser user = new User("user", "pass", 0, 0, 0);

            Assert.AreEqual(user, manager.Register("user", "pass"));
            Assert.AreEqual(user, manager.Login("user", "pass"));
            Assert.AreEqual(1, manager.AllUsers.Count);
        }

        [Test]
        public void NotRegisteredTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());

            Assert.Null(manager.Login("user", "pass"));
            Assert.AreEqual(0, manager.AllUsers.Count);
        }

        [Test]
        public void BadPasswordTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            manager.Register("user", "pass");
            Assert.Null(manager.Login("user", "pas"));
        }

        [Test]
        public void AlreadyRegisteredTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            manager.Register("user", "pass");
            Assert.Null(manager.Register("user", "pass"));
        }
    }
}
