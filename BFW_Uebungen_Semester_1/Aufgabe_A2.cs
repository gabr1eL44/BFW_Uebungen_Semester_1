using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A2
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie eine Anfangshöhe ein: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            int jumps = 0;
            while (height >= 1)
            {
                Console.WriteLine("Aktuelle Fallhöhe des Flummis beträgt: " + Math.Round(height, 2));
                height /= 2;
                jumps++;
                Thread.Sleep(500);
                Console.WriteLine("Booooooing!\n");
                Thread.Sleep(300);
            }

            Console.WriteLine("Aktuelle Fallhöhe des Flummis beträgt: " + Math.Round(height, 2));

            Console.WriteLine("\nDer Flummi hat nach {0} Sprüngen seine finale Fallhöhe (<1) erreicht!", jumps);
        }
    }
}
