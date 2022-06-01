using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D2
    {
        public static void Start()
        {
            // Initialisierung des Spielfeldes
            int[] felder = new int[20];
            for (int i = 0; i < 20; i++)
                felder[i] = 0;

            var rand = new Random();
            int segelboot, schnellboot, fregatte;

            fregatte = rand.Next(0, 18);
            for (int i = fregatte; i < (fregatte + 3); i++)
                felder[i] = 1;

            do
                schnellboot = rand.Next(0, 19);
            while ((felder[schnellboot] != 0) || (felder[schnellboot + 1] != 0));
            felder[schnellboot] = 1; felder[schnellboot + 1] = 1;

            do
                segelboot = rand.Next(0, 20);
            while (felder[segelboot] != 0);
            felder[segelboot] = 1;

            Console.WriteLine("=================");
            Console.WriteLine("Schiffe versenken");
            Console.WriteLine("=================\n");

            int versuche = 0, treffer = 0;
            // Start des Spiels
            string[] spielfeld = new string[20];
            for (int i = 0; i < 20; i++)
                spielfeld[i] = "O";
            do
            {
                int input;
                do
                {
                    foreach (var element in spielfeld)
                        Console.Write(element);
                    Console.WriteLine("\nBitte geben Sie Ihre Eingabe ein (1-20):");
                    input = Convert.ToInt32(Console.ReadLine()) - 1;
                } while ((input < 0) || (input > 19));

                versuche++;

                if (felder[input] == 1)
                {
                    treffer++;
                    felder[input] = 0;
                    spielfeld[input] = "X";

                    if (input == segelboot)
                        Console.WriteLine("Treffer! Sie haben das Segelboot versenkt!\n");
                    else if ((input == schnellboot) || (input == schnellboot + 1))
                        if ((felder[schnellboot] == 0) && (felder[schnellboot + 1] == 0))
                            Console.WriteLine("Treffer! Sie haben das Schnellboot versenkt!\n");
                        else
                            Console.WriteLine("Treffer! Sie haben das Schnellboot getroffen!\n");
                    else
                        if ((felder[fregatte] == 0) && (felder[fregatte + 1] == 0) && (felder[fregatte + 2] == 0))
                        Console.WriteLine("Treffer! Sie haben die Fregtte versenkt!\n");
                    else
                        Console.WriteLine("Treffer! Sie haben die Fregatte getroffen!\n");
                }
                else
                {
                    Console.WriteLine("Leider nicht getroffen. Das war ihr {0}. Versuch.\n", versuche);
                    spielfeld[input] = "-";
                }

            } while (treffer < 6);

            foreach (var element in spielfeld)
                Console.Write(element);
            Console.WriteLine("\nGlückwunsch! Sie haben alle Schiffe versenkt. Dafür benötigten Sie {0} Versuche", versuche);
        }
    }
}
