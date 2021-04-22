using System;

namespace OOP20_Jhaturanga_C_Sharp.Andruccioli.user
{
    public sealed class User : IUser
    {
        public User(string username, string? hashedPassword, int winCount, int drawCount, int lostCount)
        {
            this.Username = username;
            this.HashedPassword = hashedPassword;
            this.WinCount = winCount;
            this.DrawCount = drawCount;
            this.LostCount = lostCount;
        }

        public string Username { get; }

        public string? HashedPassword { get; }

        public int WinCount { get; private set; }

        public int LostCount { get; private set; }

        public int DrawCount { get; private set; }

        public int PlayedMatchCount => this.WinCount + this.DrawCount + this.LostCount;

        public void IncreaseWinCount()
        {
            this.WinCount++;
        }

        public void IncreaseDrawCount()
        {
            this.DrawCount++;
        }

        public void IncreaseLostCount()
        {
            this.LostCount++;
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   this.Username == user.Username;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Username);
        }

        public override string ToString() => "User: " + this.Username + " win: " + this.WinCount
            + " draw: " + this.DrawCount + " lost: " + this.LostCount;
    }
}
