using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A3
    {
        public static void Start()
        {
            int rightAnswers = 0, wrongAnswers = 0;

            // First question
            Console.WriteLine("Frage 1/4: Der erfolgreichste Fußball-Torschütze Europas erhält von der UEFA als Auszeichnung ...?\n");
            Console.WriteLine("(a) den Goldenen Schuh (b) das Gloldene Trikot (c) den Goldenen Ball (d) das Goldene Tor");
            char choice = Console.ReadLine().Trim().ToLower()[0];

            if (choice == 'a')
                rightAnswers++;
            else
                wrongAnswers++;

            // Second question
            Console.WriteLine("\nFrage 2/4: Wie wurde Berlin während der Berlin Blockade versorgt?\n");
            Console.WriteLine("(a) durch Überläufer (b) durch Spione (c) durch einen Tunnel (d) durch eine Luftbrücke");
            choice = Console.ReadLine().Trim().ToLower()[0];

            if (choice == 'd')
                rightAnswers++;
            else
                wrongAnswers++;

            // Third question
            Console.WriteLine("\nFrage 3/4: Was ist \"Fendant\"?\n");
            Console.WriteLine("(a) Weißwein (b) Süßspeise (c) Fischsuppe (d) Gewürzsauce");
            choice = Console.ReadLine().Trim().ToLower()[0];

            if (choice == 'a')
                rightAnswers++;
            else
                wrongAnswers++;

            // Fourth question
            Console.WriteLine("\nFrage 4/4: Wie heißt der weibliche Wal?\n");
            Console.WriteLine("(a) Walkuh (b) Walfrau (c) Walin (d) Brigitte");
            choice = Console.ReadLine().Trim().ToLower()[0];

            if (choice == 'a')
                rightAnswers++;
            else
                wrongAnswers++;

            Console.Clear();
            Console.WriteLine("Sie hatten {0} richtige und {1} falsche Antworten.", rightAnswers, wrongAnswers);
        }
    }
}
