using System;
using System.Threading;
using System.Diagnostics;

namespace BFW_Uebungen_Semester_1
{
    class MultiThreadQuick
    {
        private const int N = 100000000;
        static readonly int[] numbers = new int[N1];
        static int threadCounter = 0;

        public static int N1 => N;

        // Multithreaded Quicksort Algorithm (100M ~ 10 seconds, 1B ~ 2:30 min)
        static void Quicksort(object state)
        {
            threadCounter++;

            object[] array = state as object[];
            int startPosition = Convert.ToInt32(array[0]);
            int lengthSubArray = Convert.ToInt32(array[1]);

            int[] newNumbers = new int[lengthSubArray];
            int pivot = numbers[startPosition];

            int countLeft = 0, countRight = 0;
            for (int i = startPosition; i < startPosition + lengthSubArray; i++)
                if (numbers[i] < pivot)
                    newNumbers[countLeft++] = numbers[i];
                else if ((numbers[i] >= pivot) && (i != startPosition))
                    newNumbers[lengthSubArray - ++countRight] = numbers[i];

            newNumbers[countLeft] = pivot;

            for (int i = 0; i < lengthSubArray; i++)
                numbers[startPosition + i] = newNumbers[i];

            if (countLeft > 0)
                ThreadPool.QueueUserWorkItem(Quicksort, new object[] { startPosition, countLeft });
            if (countRight > 0)
                ThreadPool.QueueUserWorkItem(Quicksort, new object[] { startPosition + countLeft + 1, countRight });
            
            threadCounter--;
        }

        public static void Start()
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(1000);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            ThreadPool.QueueUserWorkItem(Quicksort, new object[] { 0, numbers.Length });
            while (threadCounter > -2);
           
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}m {1:00}s {2:000}ms.", ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("\nQuicksort mit {0} Zahlen => RunTime {1}\n", N1, elapsedTime);

            // Sample for control
            /*for (int i = 0; i < N / 1000; i++)
                Console.WriteLine("Zahlenwert an {0}. Stelle: {1}.", (i * 1000 + 500), numbers[i*1000 + 500]);
            Console.WriteLine();*/
        }
    }
}
