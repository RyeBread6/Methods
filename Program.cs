using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            {
                string input = Console.ReadLine();
                Console.WriteLine("Hello " + input + "!");
            }
        }
    }
}