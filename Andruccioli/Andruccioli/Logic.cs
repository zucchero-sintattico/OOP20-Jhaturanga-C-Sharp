using System;
using OOP20.usermanager;
using OOP20.userstorage;
using OOP20.validator;
using static OOP20.validator.StringValidator;
using static OOP20.validator.StringValidator.ValidationResult;
using static OOP20.EnumMessage;
using OOP20.user;
using System.Text;

namespace OOP20
{
    public static class EnumMessage
    {
        public static string Message(this ValidationResult result, string message)
        {
            return result switch
            {
                CORRECT => message + " CORRECT",
                EMPTY => message + " EMPTY",
                TOO_SHORT => message + " TOO_SHORT",
                TOO_LONG => message + " TOO_LONG",
                _ => "ERROR",
            };
        }
    }
    public class Logic : ILogic
    {
        private const int MIN_LENGTH = 2;
        private const int MAX_LENGTH = 8;
        private const string DEFAULT_USERNAME = "USER";
        private const string DEFAULT_PASSWORD = "PASSWORD";
        private const string ERROR_MESSAGE = "Error - Press a button to continue...";

        private readonly IUsersManager manager = new UsersManager(new UserDataStorageInRAMStrategy());
        private readonly Func<string, ValidationResult> validator;

        private int counter;

        public Logic()
        {
            var concatenator = new StringValidator();

            concatenator += s => s.Length < MIN_LENGTH ? TOO_SHORT : CORRECT;
            concatenator += s => s.Length > MAX_LENGTH ? TOO_LONG : CORRECT;

            validator = concatenator.Create();
        }


        public void Login()
        {
            Console.WriteLine("Insert username: ");
            string? username = Console.ReadLine();
            Console.WriteLine("Insert password: ");
            string? password = Console.ReadLine();

            if(username == null || password == null)
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.ReadKey();
            }

            IUser? user = manager.Login(username!, password!);

            if (user != null)
            {
                Console.WriteLine("Logged: " + user);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.ReadKey();
            }
        }
        public void Register()
        {
            Console.WriteLine("Insert username: ");
            string? username = Console.ReadLine();
            if (username == null)
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.ReadKey();
                return;
            }
            if (validator(username) != CORRECT)
            {
                Console.WriteLine(validator(username).Message("Username:"));
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Insert password: ");
            string? password = Console.ReadLine();
            if (password == null)
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.ReadKey();
                return;
            }
            if (validator(password) != CORRECT)
            {
                Console.WriteLine(validator(password).Message("Password:"));
                Console.ReadKey();
                return;
            }

            IUser? user = manager.Register(username, password);
            
            if (user != null)
            {
                Console.WriteLine("Registered: " + user);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ERROR_MESSAGE);
                Console.ReadKey();
            }
        }

        public void PrintUsers()
        {
            StringBuilder sb = new();
            foreach (IUser user in manager.AllUsers)
            {
                sb.AppendLine(user.ToString());
            }
            Console.Write(sb.ToString());
            Console.ReadKey();
        }
        public void Generate()
        {
            IUser user = new UserBuilder().Username(DEFAULT_USERNAME + counter).HashedPassword(DEFAULT_PASSWORD + counter++).Build();

            manager.Put(user);

            Console.WriteLine("Put: " + user);
            Console.ReadKey();
        }
    }
}