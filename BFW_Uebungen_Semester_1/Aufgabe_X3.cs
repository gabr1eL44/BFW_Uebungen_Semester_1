using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_X3
    {
        private static bool PrimeCheck(int _counter)
        {
            bool _isPrime = true;
            for (int i = 2; i < _counter; i++)
            {
                if (_counter % i == 0)
                {
                    _isPrime = false;
                    break;
                }
            }
            return _isPrime;
        }

        public static void Start()
        {
            Console.WriteLine("Wie viele Mirpzahlen möchsten Sie erzeugen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int hits = 0; int counter = 1;
            while (hits < anzahl)
            {
                counter++;

                bool isPrime = PrimeCheck(counter);
                if (!isPrime)
                    continue;

                string str = Convert.ToString(counter); string newStr = "";
                for (int i = (str.Length - 1); i >= 0; i--)
                    newStr += str[i];

                int reversedCounter = Convert.ToInt32(newStr);
                bool isReversedPrime = PrimeCheck(reversedCounter);

                if ((isPrime && isReversedPrime) && (counter != reversedCounter))
                {
                    hits++;
                    Console.WriteLine("{0}: {1} ist eine Mirpzahl!", hits, counter);
                }
            }
        }
    }
}

