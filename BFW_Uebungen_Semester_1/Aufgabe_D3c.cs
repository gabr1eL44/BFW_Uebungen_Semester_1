using System;
using System.Diagnostics;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D3c
    {
        // Quicksort Algorithm (StackOverflow ab 850k, 100k unter 1 Sekunde, 850k unter 1 Minute)
        private static void Quicksort(ref int[] _numbers, int startPosition, int lengthSubArray)
        {

            int[] newNumbers = new int[lengthSubArray];
            int pivot = _numbers[startPosition];

            int countLeft = 0, countRight = 0;
            for (int i = startPosition; i < startPosition + lengthSubArray; i++)
                if (_numbers[i] < pivot)
                    newNumbers[countLeft++] = _numbers[i];
                else if ((_numbers[i] >= pivot) && (i != startPosition))
                    newNumbers[lengthSubArray - ++countRight] = _numbers[i];
            newNumbers[countLeft] = pivot;

            for (int i = 0; i < lengthSubArray; i++)
                _numbers[startPosition + i] = newNumbers[i];

            if (countLeft > 0)
                Quicksort(ref _numbers, startPosition, countLeft);
            if (countRight > 0)
                Quicksort(ref _numbers, startPosition + countLeft + 1, countRight);  
        }

        public static void Start()
        {
            Console.WriteLine("Geben Sie die Anzahl der zu sortierenden Zahlen ein (empfohlen 100k-850k): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[N];
  
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(101);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Quicksort(ref numbers, 0, numbers.Length);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}s {1:000}ms.", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("\nQuicksort mit {0} Zahlen => RunTime {1}", N, elapsedTime);
        }
    }
}
