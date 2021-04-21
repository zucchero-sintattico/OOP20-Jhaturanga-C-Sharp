using OOP20.user;
using System;
using Xunit;

namespace AndruccioliTest
{
    public class UserTest
    {
        [Fact]
        public void CreateTest()
        {
            IUser user = new User("user", "pass", 1, 1, 1);
            Assert.NotNull(user);
        }

        [Fact]
        public void PropertyTest()
        {
            IUser user = new User("user", "pass", 1, 2, 3);
            Assert.Equal("user", user.Username);
            Assert.Equal("pass", user.HashedPassword);
            Assert.Equal(1, user.WinCount);
            Assert.Equal(2, user.DrawCount);
            Assert.Equal(3, user.LostCount);
            Assert.Equal(6, user.PlayedMatchCount);
        }

        [Fact]
        public void IncreaseTest()
        {
            IUser user = new User("user", "pass", 0, 0, 0);
            user.IncreaseWinCount();
            user.IncreaseDrawCount();
            user.IncreaseLostCount();

            Assert.Equal(1, user.WinCount);
            Assert.Equal(1, user.DrawCount);
            Assert.Equal(1, user.LostCount);
            Assert.Equal(3, user.PlayedMatchCount);
        }

        [Fact]
        public void EqualsTest()
        {
            IUser user = new User("user", "pass", 1, 2, 3);
            IUser user2 = new User("user", "pass2", 0, 0, 0);

            Assert.Equal(user, user2);
        }
    }
}
