using System;

namespace hi_to_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string User_Name = Console.ReadLine();
            Console.WriteLine("Hello "+ User_Name + "\n! Press any key to continue...");
            Console.ReadKey();
        }
    }
}
