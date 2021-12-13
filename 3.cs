   using System;

namespace osztas
{
    class osztas
    {
        static void Main(string[] args)
        {         
            

            Console.WriteLine("Kérem adjon meg két egész számot!");
            Console.Write("Első válaszott szám : ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második válaszott szám : ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            if (number3%number4!=0)
            {
                Console.WriteLine("A második szám nem osztója az elsőnek.");
            }
            else
            {
                int number5 = number3 / number4;
                Console.WriteLine("Az osztás eredménye: " + number5);
            }
        }
    }
}