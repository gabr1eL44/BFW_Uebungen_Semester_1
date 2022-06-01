using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D2
    {
        public static void Start()
        {
            // Initialisierung des Spielfeldes
            char[] spielfeld = new char[20];
            for (int i = 0; i < 20; i++)
                spielfeld[i] = '0';

            var rand = new Random();
            int segelboot, schnellboot, fregatte;

            fregatte = rand.Next(0, 18);
            for (int i = fregatte; i < (fregatte + 3); i++)
                spielfeld[i] = '1';
            
            do
                schnellboot = rand.Next(0, 19);
            while ((spielfeld[schnellboot] != '0') || (spielfeld[schnellboot + 1] != '0'));
            spielfeld[schnellboot] = '1'; spielfeld[schnellboot + 1] = '1';

            do
                segelboot = rand.Next(0, 20);
            while (spielfeld[segelboot] != '0');
            spielfeld[segelboot] = '1';

            Console.WriteLine("=================");
            Console.WriteLine("Schiffe versenken");
            Console.WriteLine("=================\n");

            int versuche = 0, treffer = 0;

            // Start des Spiels
            do
            {
                int input;
                do
                {
                    foreach (var element in spielfeld)
                        if ((element != '0') && (element != '1'))
                            Console.Write(element);
                        else
                            Console.Write("O");
                    Console.WriteLine("\nBitte geben Sie Ihre Eingabe ein (1-20):");
                    input = Convert.ToInt32(Console.ReadLine()) - 1;
                } while ((input < 0) || (input > 19));

                versuche++;

                if (spielfeld[input] == '1')
                {
                    treffer++;
                    spielfeld[input] = '0';
                    spielfeld[input] = 'X';

                    if (input == segelboot)
                        Console.WriteLine("Treffer! Sie haben das Segelboot versenkt!\n");
                    else if ((input == schnellboot) || (input == schnellboot + 1))
                        if ((spielfeld[schnellboot] == '0') && (spielfeld[schnellboot + 1] == '0'))
                            Console.WriteLine("Treffer! Sie haben das Schnellboot versenkt!\n");
                        else
                            Console.WriteLine("Treffer! Sie haben das Schnellboot getroffen!\n");
                    else
                        if ((spielfeld[fregatte] == '0') && (spielfeld[fregatte + 1] == '0') && (spielfeld[fregatte + 2] == '0'))
                        Console.WriteLine("Treffer! Sie haben die Fregtte versenkt!\n");
                    else
                        Console.WriteLine("Treffer! Sie haben die Fregatte getroffen!\n");
                }
                else
                {
                    Console.WriteLine("Leider nicht getroffen. Das war ihr {0}. Versuch.\n", versuche);
                    spielfeld[input] = '-';
                }

            } while (treffer < 6);

            foreach (var element in spielfeld)
                if ((element != '0') && (element != '1'))
                    Console.Write(element);
                else
                    Console.Write("O");
            Console.WriteLine("\nGlückwunsch! Sie haben alle Schiffe versenkt. Dafür benötigten Sie {0} Versuche", versuche);
        }
    }
}
