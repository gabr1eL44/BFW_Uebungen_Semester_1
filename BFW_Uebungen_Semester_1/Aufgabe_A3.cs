using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_A3
    {
        public static void Start()
        {
            const int amountOfQuestions = 4;
            int rightAnswers = 0, wrongAnswers = 0;

            string[] question = new string[] { "Der erfolgreichste Fußball-Torschütze Europas erhält von der UEFA als Auszeichnung ...?",
                                                "Wie wurde Berlin während der Berlin Blockade versorgt?",
                                                "Was ist \"Fendant\"?",
                                                "Wie heißt der weibliche Wal?" };
            string[,] answer = new string[4, 4] { {"den Goldenen Schuh", "das Gloldene Trikot", "den Goldenen Ball", "das Goldene Tor"},
                                                   {"durch Überläufer", "durch Spione", "durch einen Tunnel", "durche eine Luftbrücke"},
                                                   {"Weißwein", "Süßspeise", "Fischsuppe", "Gewürzsauce"},
                                                   {"Walkuh", "Walfrau", "Walin", "Brigitte" } };
            char[] solution = new char[] { 'a', 'd', 'a', 'a' };

            for (int i = 0; i < amountOfQuestions; i++)
            {
                if (i != 0) Console.WriteLine();

                Console.WriteLine("Frage {0}/{1}: {2}\n", (i + 1), amountOfQuestions, question[i]);
                Console.WriteLine("(a) {0} (b) {1} (c) {2} (d) {3}", answer[i, 0], answer[i, 1], answer[i, 2], answer[i, 3]);

                char choice = Console.ReadLine().Trim().ToLower()[0];

                if (choice == solution[i])
                    rightAnswers++;
                else
                    wrongAnswers++;
            }
            
            Console.Clear();
            Console.WriteLine("Sie hatten {0} richtige und {1} falsche Antworten.", rightAnswers, wrongAnswers);
        }
    }
}
