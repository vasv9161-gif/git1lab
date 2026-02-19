using System;

namespace lab1git
{
    class Program
    {
        static void Main()
        {
            Utils.PrintSeparator();              
            
            Console.Write("Please enter your name: "); //ввод имени 
            string name = Console.ReadLine();
            

            Console.WriteLine($"Hello, dear {name}!");            
            Utils.PrintSeparator();          
        }
    }
}