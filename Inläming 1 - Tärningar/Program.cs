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


            if (SatsadePix >= 50 && SatsadePix <= 500 && ValtLyckoTal >= 1 && ValtLyckoTal <= 6)
            {

                if (tärning1 == ValtLyckoTal && tärning2 == ValtLyckoTal && tärning3 == ValtLyckoTal)
                {

                    SatsadePix = SatsadePix *= 4;
                    pix = pix += SatsadePix;

                    Console.WriteLine("Du har Vunnit 4x " + "Pix kvar: " + pix);
                    Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning3; " + tärning2);


                }

                else if (tärning1 == ValtLyckoTal && tärning2 == ValtLyckoTal || tärning2 == ValtLyckoTal && tärning3 == ValtLyckoTal || tärning3 == ValtLyckoTal &&  tärning2 == ValtLyckoTal || tärning3 == ValtLyckoTal && tärning3 == ValtLyckoTal)
                {
                    SatsadePix = SatsadePix *= 3;
                    pix = pix += SatsadePix;

                    Console.WriteLine("Du har Vunnit 3x " + "Pix kvar: " + pix);
                    Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning3; " + tärning2);
                }
                
                else if (tärning1 == ValtLyckoTal || tärning2 == ValtLyckoTal || tärning3 == ValtLyckoTal)
                {
                    SatsadePix = SatsadePix *= 2;
                    pix = pix += SatsadePix;

                    Console.WriteLine("Du har Vunnit 2x " + "Pix kvar: " + pix);
                    Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning3; " + tärning2);


                }

                else
                {
                    pix = pix -= SatsadePix;
                    Console.WriteLine("Du har förlorat " + "Pix kvar: " + pix);

                    Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning3; " + tärning2);
                    Console.WriteLine("Pengar Kvar: " + pix);

                }

            }

            else
            {
                Console.WriteLine("Du angivit ett för stort eller litet tal");
                Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning2; " + tärning2);
                

            }


        }
        static void PengKvarOchTärningar(int tärning1, int tärning2, int tärning3, int pix)
        {

            Console.WriteLine("Tärning 1; " + tärning1 + " Tärning2; " + tärning2 + " Tärning2; " + tärning2);
            Console.WriteLine("Pengar Kvar: " + pix);
        }
    }
}
