using NUnit.Framework;
using OOP20_Jhaturanga_C_Sharp.Andruccioli.user;

namespace OOP20_Jhaturanga_C_Sharp.test.Andruccioli
{
    public class UserTest
    {
        [Test]
        public void CreateTest()
        {
            IUser user = new User("user", "pass", 1, 1, 1);
            Assert.NotNull(user);
        }

        [Test]
        public void PropertyTest()
        {
            IUser user = new User("user", "pass", 1, 2, 3);
            Assert.AreEqual("user", user.Username);
            Assert.AreEqual("pass", user.HashedPassword);
            Assert.AreEqual(1, user.WinCount);
            Assert.AreEqual(2, user.DrawCount);
            Assert.AreEqual(3, user.LostCount);
            Assert.AreEqual(6, user.PlayedMatchCount);
        }

        [Test]
        public void IncreaseTest()
        {
            IUser user = new User("user", "pass", 0, 0, 0);
            user.IncreaseWinCount();
            user.IncreaseDrawCount();
            user.IncreaseLostCount();

            Assert.AreEqual(1, user.WinCount);
            Assert.AreEqual(1, user.DrawCount);
            Assert.AreEqual(1, user.LostCount);
            Assert.AreEqual(3, user.PlayedMatchCount);
        }

        [Test]
        public void EqualsTest()
        {
            IUser user = new User("user", "pass", 1, 2, 3);
            IUser user2 = new User("user", "pass2", 0, 0, 0);

            Assert.AreEqual(user, user2);
        }
    }
}
