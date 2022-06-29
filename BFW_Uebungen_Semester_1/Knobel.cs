using System;

namespace BFW_Uebungen_Semester_1
{
    class Knobel
    {
        public static void Start()
        {
            // Lösung 1
            Console.WriteLine("Hallo".Length);
            Console.WriteLine();

            // Lösung 2
            Console.WriteLine('F' % 'A');
            Console.WriteLine();

            // Lösung 3
            Console.WriteLine("ooooo");
            Console.WriteLine("o");
            Console.WriteLine("ooooo");
            Console.WriteLine("    o");
            Console.WriteLine("ooooo");

            // Lösung 4
            int i = Convert.ToByte(true);
            Console.WriteLine();
            Console.WriteLine(i<<i<<i|i);
        }
    }
}
