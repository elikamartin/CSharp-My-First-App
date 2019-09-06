using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("hello");
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadLine();
        }
    }
}
