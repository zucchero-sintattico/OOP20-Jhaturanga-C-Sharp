using System;
using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user.builder;

namespace OOP20_Jhaturanga_C_Sharp.test.Andruccioli
{
    public class UserBuilderTest
    {
        [Test]
        public void NormalBuild()
        {
            IUserBuilder builder = new UserBuilder();
            builder.Username("user")
                .HashedPassword("pass")
                .WinCount(1)
                .DrawCount(2)
                .LostCount(3);
            IUser u = builder.Build();
            Assert.AreEqual("user", u.Username);
            Assert.AreEqual("pass", u.HashedPassword);
            Assert.AreEqual(1, u.WinCount);
            Assert.AreEqual(2, u.DrawCount);
            Assert.AreEqual(3, u.LostCount);
        }
        
        [Test]
        public void NoUsernameTest()
        {
            IUserBuilder builder = new UserBuilder();
            Assert.Throws<InvalidOperationException>(() => builder.Build());
        }

        [Test]
        public void MoreBuild()
        {
            IUserBuilder builder = new UserBuilder().Username("user");
            builder.Build();
            Assert.Throws<InvalidOperationException>(() => builder.Build());
        }
    }
}
