using System;

namespace MyProject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("1 => Sign In");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("2 => Registration");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("3 => Quit");
            Console.SetCursorPosition(50, 13);
            Console.Write("Your Choice");
            Console.SetCursorPosition(62, 13);
            var x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
                LogInPage.test();
            else if (x == 2)
                ClientRegistration.Registration();
            else
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Welcome Back!!!!");
            }

        }
    }
}
