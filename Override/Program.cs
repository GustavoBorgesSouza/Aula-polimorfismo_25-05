using System;
using Override.classes;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman m = new Megaman();
            Zero z = new Zero();

            Console.WriteLine($@"
            {m.Correr()} e {m.Pular()} 
            {z.Pular()} e {z.Correr()}");

        }
    }
}
