using System;

namespace BFW_Uebungen_Semester_1
{
    class Array
    {
        public static void Add(ref int[] _numbers, int _newNumber)
        {
            int[] tempArr = new int[_numbers.Length + 1];

            for (int i = 0; i < _numbers.Length; i++)
                tempArr[i] = _numbers[i];

            tempArr[_numbers.Length] = _newNumber;

            _numbers = tempArr;
        }

        public static int[] Add(int[] _numbers, int _newNumber)
        {
            int[] tempArr = new int[_numbers.Length + 1];

            for (int i = 0; i < _numbers.Length; i++)
                tempArr[i] = _numbers[i];

            tempArr[_numbers.Length] = _newNumber;

            return tempArr;
        }

        public static void Remove(ref int[] _numbers, int _position)
        {
            int[] tempArr = new int[_numbers.Length - 1];

            int offset = 0;

            for (int i = 0; i < _numbers.Length; i++)
                if (i != _position)
                    tempArr[i + offset] = _numbers[i];
                else
                    offset = -1;

            _numbers = tempArr;
        }

        public static int[] Remove(int[] _numbers, int _position)
        {
            int[] tempArr = new int[_numbers.Length - 1];

            int offset = 0;

            for (int i = 0; i < _numbers.Length; i++)
                if (i != _position)
                    tempArr[i + offset] = _numbers[i];
                else
                    offset = -1;

            return tempArr;
        }

        public static void Clear(ref int[] _numbers)
        {
            int[] tempArr = new int[0];

            _numbers = tempArr;
        }

        public static int[] Clear(int[] _numbers)
        {
            int[] tempArr = new int[0];

            return tempArr;
        }
    }
}
