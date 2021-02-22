using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String naam;

            Console.WriteLine("Hello world!");
            Console.WriteLine("Wie ben jij ?");
           
            naam = Console.ReadLine();
            Console.WriteLine("Hallo " + naam);
            Console.ReadLine();
        }
    }
}
