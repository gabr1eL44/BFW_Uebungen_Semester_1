using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_D3b
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

                    int skip = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if ((numbers[i - skip] < Convert.ToInt32(eingabe)) || (skip == 1))
                            tempArr[i] = numbers[i - skip];
                        else
                        {
                            tempArr[i] = Convert.ToInt32(eingabe);
                            skip = 1;
                        }
                    }

                    if (skip == 0)
                        tempArr[numbers.Length] = Convert.ToInt32(eingabe);
                    else
                        tempArr[numbers.Length] = numbers[^1];
                            
                    numbers = tempArr;
                }
            } while (eingabe != "");

            Console.Write("\nDie Zahlen sortiert lauten: ");
            foreach (var element in numbers)
                Console.Write(element + " ");
        }
    }
}
