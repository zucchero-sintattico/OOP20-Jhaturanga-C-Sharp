using OOP20.validator;
using System;
using static OOP20.validator.StringValidator.ValidationResult;

namespace OOP20
{
    public sealed class Program
    {
        public static void Main()
        {
            bool loop = true;
            ILogic logic = new Logic();

            while (loop)
            {
                Console.WriteLine("Commands:\n" +
                    "Login: l\n" +
                    "Register: r\n" +
                    "Generate new User: n\n" +
                    "Print all Users: u\n" +
                    "Exit: x\n");
                char choice = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (choice)
                {
                    case 'l':
                        logic.Login();
                        break;
                    case 'r':
                        logic.Register();
                        break;
                    case 'n':
                        logic.Generate();
                        break;
                    case 'u':
                        logic.PrintUsers();
                        break;
                    case 'x':
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Error - Not Implemented Yet");
                        break;
                }
                Console.Clear();
            }

            Console.WriteLine("Goodby :)");
        }
    }
}
