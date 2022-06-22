using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_F2
    {
        public static void Start()
        {
            string select; int durchlauf = 1;
            do
            {
                double multiplier = 2, divisor = 3;

                Console.Clear();
                Console.WriteLine("Bitte Zahl eingeben:");
                double zahl = Convert.ToDouble(Console.ReadLine());
                double temp = zahl;

                do
                {
                    int counter = 0;
                    do
                    {
                        temp *= multiplier / divisor;
                        counter++;
                    } while ((temp != 0) && (temp >= 0.01));

                    Console.WriteLine("Anzahl der Operationen: " + counter);
                    Console.ReadKey();
                    Console.Clear();

                    durchlauf++;
 
                    if (durchlauf == 2)
                    {
                        Console.WriteLine("Neuer Mulitplikator:");
                        do
                            multiplier = Convert.ToDouble(Console.ReadLine());
                        while (multiplier < 0);
                        
                        Console.WriteLine("Neuer Teiler:");
                        do
                            divisor = Convert.ToDouble(Console.ReadLine());
                        while (divisor < multiplier);

                        temp = zahl;
                    }
                    else if (durchlauf == 3)
                    {
                        Console.WriteLine("Neue Zahl:");
                        temp = Convert.ToDouble(Console.ReadLine());
                    }
                    else if (durchlauf == 4)
                        break;
                } while (durchlauf < 4);

                Console.WriteLine("Möchten Sie das Program beenden (j/n)?");
                select = Console.ReadLine();

                durchlauf = 1;
            } while (select == "n");
        }
    }
}
