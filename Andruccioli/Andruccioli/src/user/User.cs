using System;

namespace OOP20.user
{
    sealed class User : IUser
    {
        private readonly string username;
        private readonly string? hashedPassword;
        private int winCount;
        private int drawCount;
        private int lostCount;

        public User(string username, string hashedPassword, int winCount, int drawCount, int lostCount)
        {
            this.username = username;
            this.hashedPassword = hashedPassword;
            this.winCount = winCount;
            this.drawCount = drawCount;
            this.lostCount = lostCount;
        }

        public string Username => username;

        public string? HashedPassword => hashedPassword;

        public int WinCount => winCount;

        public int LostCount => lostCount;

        public int DrawCount => drawCount;

        public int PlayedMatchCount => winCount + drawCount + lostCount;

        public void IncreaseDrawCount()
        {
            this.drawCount++;
        }

        public void IncreaseLostCount()
        {
            this.lostCount++;
        }

        public void IncreaseWinCount()
        {
            this.winCount++;
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   username == user.username;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(username);
        }

        public override string ToString() => "User: " + this.username + " win: " + this.winCount
            + " draw: " + this.drawCount + " lost: " + this.lostCount;
    }
}
