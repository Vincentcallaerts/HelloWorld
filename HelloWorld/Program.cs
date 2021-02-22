using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string mood;
            string heleZin;

            Console.WriteLine("Hello world!");
            Console.WriteLine("Wie ben jij ?");
           
            naam = Console.ReadLine();
            Console.WriteLine("Hallo " + naam);
            Console.WriteLine("Hoe gaat het met jouw ");
            mood = Console.ReadLine();

            Console.Write("Met mij gaat het ook ");
            Console.Write(mood);
            Console.WriteLine(".");

            Console.WriteLine("Met mij gaat het ook " + mood);
           
            Console.WriteLine("Met mij gaat het ook {0} ", mood);
            Console.WriteLine($"Met mij gaat het ook {mood}");

            heleZin = $"Met mij gaat het ook {mood}.";
            Console.WriteLine(heleZin);

            Console.ReadLine();
        }
    }
}
