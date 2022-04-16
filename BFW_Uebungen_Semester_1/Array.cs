using System;

namespace BFW_Uebungen_Semester_1
{
    class Array
    {
        public static bool Push(ref int[] _numbers, int _newNumber)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length + 1];

                for (int i = 0; i < _numbers.Length; i++)
                    tempArr[i] = _numbers[i];

                tempArr[_numbers.Length] = _newNumber;
                _numbers = tempArr;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Pop(ref int[] _numbers, out int _oldNumber)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length - 1];

                for (int i = 0; i < _numbers.Length - 1; i++)
                    tempArr[i] = _numbers[i];

                _oldNumber = _numbers[^1];
                _numbers = tempArr;

                return true;
            }
            catch
            {
                _oldNumber = 0;
                return false;
            }
        }

        public static bool Pop(ref int[] _numbers)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length - 1];

                for (int i = 0; i < _numbers.Length - 1; i++)
                    tempArr[i] = _numbers[i];

                _numbers = tempArr;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Insert(ref int[] _numbers, int _newNumber, int _position)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length + 1];

                int offset = 0;

                for (int i = 0; i < _numbers.Length + 1; i++)
                    if (i != _position)
                        tempArr[i] = _numbers[i - offset];
                    else
                    {
                        tempArr[i] = _newNumber;
                        offset = 1;
                    }

                _numbers = tempArr;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Remove(ref int[] _numbers, out int _oldNumber, int _position)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length - 1];

                int offset = 0;

                for (int i = 0; i < _numbers.Length; i++)
                    if (i != _position)
                        tempArr[i + offset] = _numbers[i];
                    else
                        offset = -1;

                _oldNumber = _numbers[_position];
                _numbers = tempArr;

                return true;
            }
            catch
            {
                _oldNumber = 0;
                return false;
            }
        }

        public static bool Remove(ref int[] _numbers, int _position)
        {
            try
            {
                int[] tempArr = new int[_numbers.Length - 1];

                int offset = 0;

                for (int i = 0; i < _numbers.Length; i++)
                    if (i != _position)
                        tempArr[i + offset] = _numbers[i];
                    else
                        offset = -1;

                _numbers = tempArr;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Init(out int[] _numbers)
        {
            int[] tempArr = new int[0];

            _numbers = tempArr;

            return true;
        }

         public static bool Reset(ref int[] _numbers)
        {
            int[] tempArr = new int[0];

             _numbers = tempArr;

            return true;
        }

        public static int Length(ref int[] _numbers)
        {
            return _numbers.Length;
        }
    }
}
