using System;

namespace lab1git
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            
            Console.Write("Enter login: ");
            string login = Console.ReadLine();
            
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
        }
    }
}
}