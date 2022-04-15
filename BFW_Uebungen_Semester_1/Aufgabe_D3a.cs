using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D3a
    {
        public static void Start()
        {
            int[] numbers = new int[0];

            string eingabe;
            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
                eingabe = Console.ReadLine();

                if (eingabe != "")
                {
                    int[] tempArr = new int[numbers.Length + 1];
                    for (int i = 0; i < numbers.Length; i++)
                        tempArr[i] = numbers[i];

                    tempArr[numbers.Length] = Convert.ToInt32(eingabe);
                    numbers = tempArr;
                }
            } while (eingabe != "");

            bool switched;
            do
            {
                switched = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        switched = true;
                    }
            } while (switched);

            Console.Write("\nDie Zahlen sortiert lauten: ");
            foreach (var element in numbers)
                Console.Write(element + " ");
        }
    }
}
