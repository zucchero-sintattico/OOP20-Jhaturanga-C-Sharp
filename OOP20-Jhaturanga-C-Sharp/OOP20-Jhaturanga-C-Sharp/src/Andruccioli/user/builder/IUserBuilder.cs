namespace OOP20_Jhaturanga_C_Sharp.Andruccioli.user.builder
{
    public interface IUserBuilder
    {

        /// <param name="username">username of the User that is unique</param>
        /// <returns>the Builder</returns>
        IUserBuilder Username(string username);

        /// <param name="hashedPassword">hashedPassword of the User</param>
        /// <returns>the Builder</returns>
        IUserBuilder HashedPassword(string hashedPassword);

        /// <param name="count">count of the win match</param>
        /// <returns>the Builder</returns>
        IUserBuilder WinCount(int count);

        /// <param name="count">count of the draw match</param>
        /// <returns>the Builder</returns>
        IUserBuilder DrawCount(int count);

        /// <param name="count">count of the lost match</param>
        /// <returns>the Builder</returns>
        IUserBuilder LostCount(int count);

        /// <returns>the User built</returns>
        User Build();
    }
}
