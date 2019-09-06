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
            Console.WriteLine("When were you born? Please enter the year: ");
            int year;
            year = int.Parse (Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine("you are" + age + "years old");

            Console.ReadLine();
        }
    }
}
