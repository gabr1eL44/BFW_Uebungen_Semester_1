using System;

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
                else if (_numbers[i] > pivot)
                    newNumbers[lengthSubArray - ++countRight] = _numbers[i];
            newNumbers[countLeft] = pivot;

            for (int i = 0; i < lengthSubArray; i++)
                _numbers[startPosition + i] = newNumbers[i];

            if (countLeft > 0)
                Quicksort(ref _numbers, startPosition, countLeft);
            if (countRight > 0)
                Quicksort(ref _numbers, countLeft + 1, countRight);  
        }

        public static void Start()
        {
            const int N = 8;
            int[] numbers = new int[N];

            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(101);

            Quicksort(ref numbers, 0, numbers.Length);

            foreach (var element in numbers)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
