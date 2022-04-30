using System;
using System.Diagnostics;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D3c
    {
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
            const int N = 500000;
            int[] numbers = new int[N];
            int[] numbersOLD = new int[N];

            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(101);
                numbersOLD[i] = numbers[i];
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Quicksort(ref numbers, 0, numbers.Length);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}s {1:000}ms.", ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Quicksort mit {0} Zahlen => RunTime {1}", N, elapsedTime);

            /* Vergleich mit Bubble Sort
            int quickTime = ts.Seconds * 1000 + ts.Milliseconds;

            stopWatch.Reset();
            stopWatch.Start();

            bool switched;
            do
            {
                switched = false;
                for (int i = 0; i < numbersOLD.Length - 1; i++)
                    if (numbersOLD[i] > numbersOLD[i + 1])
                    {
                        int temp = numbersOLD[i];
                        numbersOLD[i] = numbersOLD[i + 1];
                        numbersOLD[i + 1] = temp;

                        switched = true;
                    }
            } while (switched);

            stopWatch.Stop();
            ts = stopWatch.Elapsed;

            elapsedTime = String.Format("{0:00}s {1:000}ms", ts.Seconds, ts.Milliseconds);
            int bubbleTime = ts.Seconds * 1000 + ts.Milliseconds;
            Console.WriteLine("Bubble Sort mit {0} Zahlen => RunTime {1}", N, elapsedTime);

            Console.WriteLine("\nQuick Sort ist {0}-mal so schnell wie Bubble Sort!", Math.Round((double)bubbleTime/quickTime), 3);*/
        }
    }
}
