namespace OOP20
{
    interface ILogic
    {
        /// <summary>
        /// Login a User
        /// </summary>
        void Login();

        /// <summary>
        /// Register a User
        /// </summary>
        void Register();

        /// <summary>
        /// Print all Users
        /// </summary>
        void PrintUsers();

        /// <summary>
        /// Generate a new user
        /// </summary>
        void Generate();
    }
}