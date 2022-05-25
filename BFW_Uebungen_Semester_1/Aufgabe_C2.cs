using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C2
    {
        public static void Start()
        {
            int[] zutaten = new int[6]; int[] mengen = new int[] { 250, 125, 1, 75, 2, 1 };

            Console.Write("Bitte geben Sie die Menge an Mehl ein (g):                     ");
            zutaten[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie die Menge an Butter (g) ein:                   ");
            zutaten[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie die Anzahl der Eier ein:                       ");
            zutaten[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben die die Menge an Zucker (g) ein:                   ");
            zutaten[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie die Anzahl an Päckchen Vanilinzucker ein (Pk): ");
            zutaten[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie die Anzahl an Prisen Salz ein:                 ");
            zutaten[5] = Convert.ToInt32(Console.ReadLine());

           int maximum = zutaten[0] / mengen[0];
            for (int i = 1; i < 6; i++)
            {
                int j = zutaten[i] / mengen[i];
                if (j < maximum)
                    maximum = j;
            }
            Console.WriteLine("\nSie können maximal {0} Kekse backen", maximum * 5);

            Console.WriteLine("\nDafür benötigen Sie die folgenden Mengen an Mehl, Butter, Eiern, Zucker, Vanilin und Salz..");
            for (int i = 0; i < 6; i++)
                Console.WriteLine(maximum * mengen[i]);
        }
    }
}
