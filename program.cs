using System;

namespace lab1git
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter login: ");       //логин
            string login = Console.ReadLine();
            
            Console.Write("Enter password: ");     //пароль
            string password = Console.ReadLine();  
            
            if (Auth.CheckLogin(login, password))  //проверка
            {
                Console.WriteLine($"Welcome, {login}!");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }
    }
}