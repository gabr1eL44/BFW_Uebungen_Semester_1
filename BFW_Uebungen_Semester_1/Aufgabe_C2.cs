using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C2
    {
        public static void Start()
        {
            int[] zutatenMenge = new int[6]; int[] mengen = new int[] { 250, 125, 1, 75, 2, 1 };
            string[] zutaten = new string[] { "Mehl", "Butter", "Eier", "Zucker", "Vanilinzucker", "Salz"};

            for (int i = 0; i < zutaten.Length; i++)
            {
                Console.Write("Bitte geben Sie die Menge an {0} ein: ", zutaten[i]);
                zutatenMenge[i] = Convert.ToInt32(Console.ReadLine());
            }

           int maximum = zutatenMenge[0] / mengen[0];
            for (int i = 1; i < 6; i++)
            {
                int j = zutatenMenge[i] / mengen[i];
                if (j < maximum)
                    maximum = j;
            }
            Console.WriteLine("\nSie können maximal {0} Kekse backen", maximum * 5);

            for (int i = 0; i < 6; i++)
                Console.WriteLine("Benötigte Menge an {0}: {1}", zutaten[i], maximum * mengen[i]);
        }
    }
}
