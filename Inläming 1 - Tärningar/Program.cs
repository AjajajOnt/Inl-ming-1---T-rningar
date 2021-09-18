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
            Console.WriteLine("Välj ett lyckotal mellan 1 och 6");
            ValtLyckoTal = int.Parse(Console.ReadLine());
            int SatsadePix = 0;
            Console.WriteLine("Satsa Pix");
            SatsadePix = int.Parse(Console.ReadLine());

            if (tärning1 == ValtLyckoTal || tärning2 == ValtLyckoTal || tärning3 == ValtLyckoTal)
            {
                SatsadePix = SatsadePix *= 2;
                pix = pix += SatsadePix;
                Console.WriteLine("Du har Vunnit " + "Pix kvar: " + pix);


            }
            else
            {
                pix = pix -= SatsadePix;
                Console.WriteLine("Du har förlorat " + "Pix kvar: " + pix);

            }

        }
    }
}
