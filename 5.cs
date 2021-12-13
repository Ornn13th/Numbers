using System;

namespace age
{


    class age
    {
        static void Main(string[] args)
        {

            Console.Write("Kérem adja meg a nevét: ");
            string name = Console.ReadLine();
            Console.Write("Kérem adja meg születési évét : ");
            int birthdate = Convert.ToInt32(Console.ReadLine());
            string date = DateTime.Now.ToString("yyyy");
            int year = Convert.ToInt32(date);
            int age = year - birthdate;
            Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                int m = Console.WindowHeight;
                int sz = Console.WindowWidth;
                Console.SetCursorPosition(sz / 2, m / 2);
                Console.OpenStandardOutput();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name);
                Console.SetCursorPosition(sz / 2, m / 2+1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(age);
        }
    }
}  
           