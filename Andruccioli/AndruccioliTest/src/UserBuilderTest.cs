using OOP20.user;
using System;
using OOP20.user.builder;
using Xunit;

namespace Test
{
    public class UserBuilderTest
    {
        [Fact]
        public void NormalBuild()
        {
            IUserBuilder builder = new UserBuilder();
            builder.Username("user")
                .HashedPassword("pass")
                .WinCount(1)
                .DrawCount(2)
                .LostCount(3);
            IUser u = builder.Build();
            Assert.Equal("user", u.Username);
            Assert.Equal("pass", u.HashedPassword);
            Assert.Equal(1, u.WinCount);
            Assert.Equal(2, u.DrawCount);
            Assert.Equal(3, u.LostCount);
        }
        [Fact]
        public void NoUsernameTest()
        {
            IUserBuilder builder = new UserBuilder();
            Assert.Throws<InvalidOperationException>(() => builder.Build());
        }

        [Fact]
        public void MoreBuild()
        {
            IUserBuilder builder = new UserBuilder().Username("user");
            builder.Build();
            Assert.Throws<InvalidOperationException>(() => builder.Build());
        }
    }
}
