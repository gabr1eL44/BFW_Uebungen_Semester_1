using System;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Snacks
    {
        public static void Start()
        {
            Random rnd = new Random();

            int[] faecher = new int[16];
            for (int i = 0; i < faecher.Length; i++)
                faecher[i] = rnd.Next(6);

            const decimal preisSnack = 1.5M; decimal guthaben = 0M;

            // Setting Encodings for € sign
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                bool isValidInput = false; decimal value; char currency; int fachNummer = 0;
                do
                {
                    for (int i = 0; i < faecher.Length; i++)
                    {
                        Console.Write("[{0}]:{1}", i, faecher[i]);
                        if (i < faecher.Length - 1)
                            Console.Write(" || ");
                        else
                            Console.WriteLine("\nGuthaben: {0} €\n", guthaben.ToString("0.00"));
                    }
                    Console.Write("Bitte wählen Sie ein Fach (0-15) oder werfen Sie Geld ein (A für Abbruch): ");
                    string input = Console.ReadLine().Trim();

                    currency = input[^1];
                    if (currency == '€')
                    {
                        isValidInput = decimal.TryParse(input[..^1], out value);
                        guthaben += value;
                    }
                    else if (input.ToUpper() == "A")
                    {
                        Console.WriteLine("\nIhr Guthaben von {0} € wird ausgezahlt. Auf Wiedersehen!", guthaben.ToString("0.00"));
                        guthaben = 0;
                        return;
                    }
                    else
                    {
                        isValidInput = int.TryParse(input, out fachNummer);
                        if (fachNummer < 0 || fachNummer > 15)
                            isValidInput = false;
                    }

                    if (!isValidInput)
                        Console.WriteLine("Fehlerhafte Eingabe. Bitte erneut versuchen!\n");

                } while (!isValidInput || currency == '€');

                Console.WriteLine("\nSie haben Fach {0} gewählt!", fachNummer);
                if (guthaben >= preisSnack)
                {
                    if (faecher[fachNummer] > 0)
                    {
                        guthaben -= preisSnack;
                        faecher[fachNummer]--;
                        Console.WriteLine("Bitte entnehmen Sie Ihren Snack.\n");
                    }
                    else
                        Console.WriteLine("Das Fach ist leer. Bitte wählen Sie ein anderes.\n");
                }
                else
                    Console.WriteLine("Ihr Guthaben ({0} €) ist nicht ausreichend. Ein Snack kostet {1} €. Bitte werfen Sie mehr Geld ein!\n", guthaben.ToString("0.00"), preisSnack.ToString("0.00"));
            };
        }
    }
}
