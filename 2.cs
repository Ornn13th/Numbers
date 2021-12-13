   using System;

namespace parity
{
    class parity
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Kérem adjon egy egész számot!");
            Console.Write("Válaszott szám : ");
            int parity = Convert.ToInt32(Console.ReadLine());

            if (parity == 0)
            {
                Console.WriteLine("Az ön száma a 0.");
            }
            else if (parity % 2 == 0)
            {
                Console.WriteLine("Az ön száma páros.");
            }
            else 
            { 
            Console.WriteLine("Az ön száma páratlan.");
            }
        }
    }
}