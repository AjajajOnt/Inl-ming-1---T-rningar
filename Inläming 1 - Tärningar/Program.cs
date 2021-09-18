using System;

namespace Inläming_1___Tärningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pix = 500;
            int tärning1 = rnd.Next(1,6);
            int tärning2 = rnd.Next(1,6);
            int tärning3 = rnd.Next(1,6);
            int ValtLyckoTal = 0;
            ValtLyckoTal = int.Parse(Console.ReadLine());

            if (tärning1 == ValtLyckoTal || tärning2 == ValtLyckoTal || tärning3 == ValtLyckoTal)
            {

                Console.WriteLine("Du har Vunnit");

            }
            else
            {
                Console.WriteLine("Du har förlorat");
            }

        }
    }
}
