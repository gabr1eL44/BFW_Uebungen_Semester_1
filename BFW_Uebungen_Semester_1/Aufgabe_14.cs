using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_14
    {
        public static void Start()
        {
            Console.Write("Hallo! Geben Sie eine Zahl ein: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Die Zahl ist gerade!");
            else
                Console.WriteLine("Die Zahl ist ungerade!");

            if (number < 10)
                Console.WriteLine("Die Zahl ist kleiner als 10!");
            else if (number < 100)
                Console.WriteLine("Die Zahl ist kleiner als 100!");
            else 
                Console.WriteLine("Die Zahl ist größer als 100!");
            
            if (number % 7 == 0)
                Console.WriteLine("Die Zahl ist durch 7 teilbar!");
            else
                Console.WriteLine("Die Zahl ist nicht durch 7 teilbar!");

            if (Math.Abs(number) < 100)
                Console.WriteLine("Die Zahl hat weniger als 3 Stellen!");
            else
                Console.WriteLine("Die Zahl hat mindestens 3 Stellen!");
        }
    }
}
