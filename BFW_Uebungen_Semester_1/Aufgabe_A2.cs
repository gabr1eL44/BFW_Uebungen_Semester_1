using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A2
    {
        public static void Start()
        {
            double height;
            do
            {
                Console.Write("Bitte geben Sie eine Anfangshöhe ein (m): ");
            } while (!double.TryParse(Console.ReadLine(), out height));

            Console.Clear();

            int jumps = 0;
            while (height >= 0.01)
            {
                Console.WriteLine("Aktuelle Fallhöhe des Flummis beträgt: " + Math.Round(height, 2));
                height /= 2;
                jumps++;
                Console.WriteLine("Booooooing!\n");
            }

            Console.WriteLine("Aktuelle Fallhöhe des Flummis beträgt: " + height.ToString("0.00"));

            Console.WriteLine("\nDer Flummi hat nach {0} Sprüngen seine finale Fallhöhe (<0.01 m) erreicht!", jumps);
        }
    }
}
