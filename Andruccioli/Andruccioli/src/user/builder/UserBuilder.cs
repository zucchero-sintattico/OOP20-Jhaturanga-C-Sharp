using System;

namespace OOP20.user.builder
{
    public sealed class UserBuilder : IUserBuilder
    {
        private string? username;
        private string? hashedPassword;
        private int winCount;
        private int drawCount;
        private int lostCount;
        private bool build;

        public IUserBuilder Username(string username)
        {
            this.username = username;
            return this;
        }
        
        public IUserBuilder HashedPassword(string hashedPassword)
        {
            this.hashedPassword = hashedPassword;
            return this;
        }

        public IUserBuilder WinCount(int count)
        {
            this.winCount = count;
            return this;
        }

        public IUserBuilder DrawCount(int count)
        {
            this.drawCount = count;
            return this;
        }

        public IUserBuilder LostCount(int count)
        {
            this.lostCount = count;
            return this;
        }

        public User Build()
        {
            if(this.build)
            {
                throw new InvalidOperationException("Too many builds");
            }
            if (username == null)
            {
                throw new InvalidOperationException("Need to set the username");
            }
            build = true;
            return new User(this.username!, this.hashedPassword, this.winCount, this.drawCount, this.lostCount);
        }
    }
}
