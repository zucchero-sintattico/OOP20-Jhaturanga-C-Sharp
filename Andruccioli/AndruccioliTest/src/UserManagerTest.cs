

using OOP20.user;
using OOP20.usermanager;
using OOP20.userstorage;
using Xunit;

namespace Test
{
    public class UserManagerTest
    {
        [Fact]
        public void NormalUsingTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            IUser user = new User("user", "pass", 0, 0, 0);

            Assert.Equal(user, manager.Register("user", "pass"));
            Assert.Equal(user, manager.Login("user", "pass"));
            Assert.Equal(1, manager.AllUsers.Count);
        }

        [Fact]
        public void NotRegisteredTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());

            Assert.Null(manager.Login("user", "pass"));
            Assert.Equal(0, manager.AllUsers.Count);
        }

        [Fact]
        public void BadPasswordTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            manager.Register("user", "pass");
            Assert.Null(manager.Login("user", "pas"));
        }

        [Fact]
        public void AlreadyRegisteredTest()
        {
            IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
            manager.Register("user", "pass");
            Assert.Null(manager.Register("user", "pass"));
        }
    }
}
