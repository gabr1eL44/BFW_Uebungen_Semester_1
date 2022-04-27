using System;


namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D3c
    {
        private static void Quicksort(ref int[] _numbers, int _startPosition, int _lengthArray)
        {
            int pivot = _numbers[_startPosition];
            int[] _numbersNew = new int[_numbers.Length];

            for (int i = 0; i < _numbers.Length; i++)
                _numbersNew[i] = _numbers[i];


            int _countLeft = _startPosition; int _countRight = _startPosition + _lengthArray - 1;
            for (int i = _startPosition; i < _startPosition + _lengthArray; i++)
            {
                if (_numbers[i] < pivot)
                    _numbersNew[_countLeft++] = _numbers[i];
                else
                    _numbersNew[_countRight--] = _numbers[i];
            }

            _numbers = _numbersNew;
            int _splitPosition = _countRight + 1;

            if (_splitPosition - _startPosition > 1)
                 Quicksort(ref _numbers, _startPosition, _splitPosition - _startPosition);
            if (_lengthArray - _splitPosition > 1)
                 Quicksort(ref _numbers, _splitPosition, _lengthArray - _splitPosition);
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
                Console.WriteLine(element);
        }
    }
}
