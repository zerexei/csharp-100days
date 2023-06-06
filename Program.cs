using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // ++++++++++++> loop <++++++++++++++++
            int i = 0;
            do
            {
                Console.Write("Input: ");
                string? name;
                name = Console.ReadLine();
                Console.WriteLine($"{i}: {name}");
                if (i == 10) break;
                i++;
            } while (true);

            // int i = 0;
            // while (i < 10)
            // {
            //     Console.Write("Input: ");
            //     string? name;
            //     name = Console.ReadLine();
            //     Console.WriteLine($"{i}: {name}");
            //     i++;
            // }

            // for (int i = 0; i < 10; i++)
            // {

            //     Console.Write("Input: ");
            //     string? name;
            //     name = Console.ReadLine();
            //     Console.WriteLine($"{i}: {name}");
            // }

            // ++++++++++++> if statement <++++++++++++++++
            // int age = 15;
            // string status;

            // if (age < 13)
            //     status = "Child";
            // else if (age < 20)
            //     status = "Teen";
            // else if (age < 60)
            //     status = "Adult";
            // else
            //     status = "Old";

            // char message = status == "Teen" ? '1' : '0';

            // Console.WriteLine("status: {0} | message: {1}", status, message);

            // ++++++++++++> I/O <++++++++++++++++
            // Console.WriteLine("What is your name?");
            // Console.Write("Type you first name: ");
            // string? first_name;
            // first_name = Console.ReadLine();

            // Console.Write("Type you last name: ");
            // string? last_name = Console.ReadLine();

            // Console.WriteLine($"Hello, {first_name} {last_name}");
            // Console.ReadLine();

            // int x = 1;
            // int y = x + 31;
            // Console.WriteLine(y + "123");


            // ++++++++++++>  <++++++++++++++++
            // // See https://aka.ms/new-console-template for more information
            // Console.WriteLine("Hello, World\nEnter your name: ");

            // string? test = Console.ReadLine();
            // Console.WriteLine($"[{test}]");

            // string str = "Hello";
            // Console.WriteLine($"[{str}]");
        }
    }
}
