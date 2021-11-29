using System;

namespace hello_kian
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("what's your name? "); 
        string name = Console.ReadLine(); 
        Console.WriteLine("Hello " + name); // Hello name //
            Console.Write("what's your birth year? ");
         string year = Console.ReadLine();
            int age = 2021 - int.Parse(year);
            Console.WriteLine("your age: " + age);
            Console.ReadKey();
        }
    }
}
