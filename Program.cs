using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World\nEnter your name: ");

            string test = Console.ReadLine();
            Console.WriteLine($"[{test}]");

            string str = "Hello";
            Console.WriteLine($"[{str}]");



        }
    }
}
