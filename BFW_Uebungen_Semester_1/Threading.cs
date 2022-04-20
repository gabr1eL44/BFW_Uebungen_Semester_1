using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Threading
    {
        public static int eingabe;
        public static string str = "Bitte geben Sie innerhalb von 5 Sekunden eine Zahl ein: ";

        public static void CallToChildThread()
        {
            Console.WriteLine(str);
            int.TryParse(Console.ReadLine(), out eingabe);
        }
        public static void Start()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);

            childThread.Start();
            Thread.Sleep(100);

            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Ihnen bleiben noch {0} Sekunden Zeit!", (5 - i));
                Console.SetCursorPosition(str.Length, 0);
                if (eingabe != 0)
                    break;
                Thread.Sleep(1000);
            }

            Console.SetCursorPosition(0, 4);
            if (eingabe == 0)
                Console.WriteLine("Sie haben leider nicht rechtzeitig eine Eingabe gemacht!");
            else
                Console.WriteLine("Ihre Eingabe lautete: " + eingabe);
        }
    }
}
