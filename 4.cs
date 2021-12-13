using System;

namespace triangle
{
    class triangle
    {
        static void Main(string[] args)
        {


Console.WriteLine("Adja meg a háromszög oldalainak hosszát mm-ben!");
            Console.Write("a oldal hossza: ");
            int aoldal = Convert.ToInt32(Console.ReadLine());
            Console.Write("b oldal hossza: ");
            int boldal = Convert.ToInt32(Console.ReadLine());
            Console.Write("c oldal hossza: ");
            int coldal = Convert.ToInt32(Console.ReadLine());

            if (aoldal + boldal > coldal)
            {
                if (aoldal < boldal + coldal) 
                {

                    if (coldal + aoldal > boldal) 
                    {
                        Console.WriteLine("A háromszög megszerkeszthető!");
                    }
                    else
                    {
                        Console.WriteLine("A háromszög nem szerkeszthető meg!");
                    }
                }

                else
                {
                    Console.WriteLine("A háromszög nem szerkeszthető meg!");
                }

            }

            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető meg!");
            }

        }
    }
}

