using System;
using System.Threading;

namespace MyProject
{
    static class LogInPage
    {
        public static void test()
        {
            Console.Clear();
            Console.Write("Username: ");
                var username = Console.ReadLine(); 
            Console.Write("Password: ");
                var password = Console.ReadLine();
            if (username == "admin")
                AdminPage.Show();
            else if (username == "user")
                UserPage.Show(); 
            else
            {
                Console.Clear();
                Console.WriteLine("Something is going wrong");
                Console.WriteLine("Try again after a second");
                Thread.Sleep(2000);
                LogInPage.test();
            }
        }
    }
}
