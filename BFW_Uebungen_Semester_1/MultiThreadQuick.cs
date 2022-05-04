using System;
using System.Threading;
using System.Diagnostics;

namespace BFW_Uebungen_Semester_1
{
    class MultiThreadQuick
    {
        private const int N = 100000001;
        static readonly int[] numbers = new int[N1];
        static int threadCounter = 0;

        public static int N1 => N;

        // Multithreaded Quicksort Algorithm (100M ~ 10 seconds, 1B ~ 2:30 min)
        private static void Quicksort(object state)
        {
            threadCounter++;

            object[] array = state as object[];
            int startPosition = Convert.ToInt32(array[0]);
            int lengthSubArray = Convert.ToInt32(array[1]);

            int countLeft = 0, countRight = 0;
            {
                int[] newNumbers = new int[lengthSubArray];
                int pivot = numbers[startPosition];

                for (int i = startPosition; i < startPosition + lengthSubArray; i++)
                    if (numbers[i] < pivot)
                        newNumbers[countLeft++] = numbers[i];
                    else if ((numbers[i] >= pivot) && (i != startPosition))
                        newNumbers[lengthSubArray - ++countRight] = numbers[i];

                newNumbers[countLeft] = pivot;

                for (int i = 0; i < lengthSubArray; i++)
                    numbers[startPosition + i] = newNumbers[i];
            }

            if (countLeft > 0)
                ThreadPool.QueueUserWorkItem(Quicksort, new object[] { startPosition, countLeft });
            if (countRight > 0)
                ThreadPool.QueueUserWorkItem(Quicksort, new object[] { startPosition + countLeft + 1, countRight });
            
            threadCounter--;
        }

        public static void Start()
        {
            Random rnd = new Random();
            Console.WriteLine("Erzeugen der Zufallszahlen");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1001);
                if (i % 10000000 == 0)
                    Console.Write(".");
            }

            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("\n\nBeginne mit Sortierung");
            stopWatch.Start();

            ThreadPool.QueueUserWorkItem(Quicksort, new object[] { 0, numbers.Length });
            while (threadCounter > -2);
             
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nSortierung abgeschlossen");

            string elapsedTime = String.Format("{0:00}m {1:00}s {2:000}ms.", ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Quicksort mit {0} Zahlen => RunTime {1}", (N1 - 1), elapsedTime);
            Console.ReadKey();

            // Sample for control
            Console.WriteLine("\nStichprobenartige Kontrolle");
            Console.WriteLine("===========================");
            for (int i = 0; i <= N; i+=1000000)
                Console.WriteLine("Zahlenwert an {0}. Stelle: {1}.", i, numbers[i]);
        }
    }
}
