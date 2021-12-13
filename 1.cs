using System;

namespace alapmuv
{
    class alapmuv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg két egész számot!");
            Console.Write("Első válaszott szám : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második válaszott szám : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int addition = number1 + number2;
            int substraction = number1 - number2;
            int multiplication = number1 * number2;
            int division = number1 / number2;
            Console.WriteLine("Összeg = " + addition);
            Console.WriteLine("Szorzat = " + multiplication);

            if (number1 > number2)
            {
                Console.WriteLine("Különbség = " + substraction);
                Console.WriteLine("Hányados = " + division);
            }
            else
            {
                int substraction1 = number2 - number1;
                double division1 = number2 / number1;
                Console.WriteLine("Különbség = " + substraction1);
                Console.WriteLine("Hányados = " + division1);
            }


        }
    }







}
