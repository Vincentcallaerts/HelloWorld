using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabels
            string naam;
            string mood;
            string heleZin;
            
            //start
            Console.WriteLine("Hello world!");
            Console.WriteLine("Wie ben jij ?");

            naam = Console.ReadLine();
            Console.WriteLine("Hallo " + naam);
            Console.WriteLine("Hoe gaat het met jouw ");
            mood = Console.ReadLine();
           
            //eerste manier
            Console.Write("Met mij gaat het ook ");
            Console.Write(mood);
            Console.WriteLine(".");

            //tweede manier
            Console.WriteLine("Met mij gaat het ook " + mood + ".");
            
            //derde manier 
            Console.WriteLine("Met mij gaat het ook {0}. ", mood);
            
            //vierde manier
            Console.WriteLine($"Met mij gaat het ook {mood}.");
            
            //vijfde manier
            heleZin = $"Met mij gaat het ook {mood}.";
            Console.WriteLine(heleZin);
            
            /*blokje comment
             muliple lines woohoow*/
            //Is zodat console zichzelf niet dichtgooit
            Console.ReadLine();
        }
    }
}
