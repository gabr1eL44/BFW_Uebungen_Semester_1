using System;
using System.Collections.Generic;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_X3
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Mirpzahlen möchsten Sie erzeugen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int hits = 0; int counter = 1;
            while (hits < anzahl)
            {
                counter++;

                bool isPrime = true;
                for (int i=2; i < counter; i++)
                {
                    if (counter % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (isPrime == false)
                        break;
                }
                if (!isPrime)
                    continue;

                string str = Convert.ToString(counter); string newStr = "";
                for (int i = (str.Length - 1); i >=0; i--)
                    newStr += str[i];

                int reversedcounter = Convert.ToInt32(newStr);

                bool isReversedPrime = true;
                for (int i=2; i < reversedcounter; i++)
                {
                    if (reversedcounter % i == 0)
                    {
                        isReversedPrime = false;
                        break;
                    }
                    if (isReversedPrime == false)
                        break;
                }

                if (isPrime && isReversedPrime)
                {
                    hits++;
                    Console.WriteLine("{0}: {1} ist eine Mripzahl!", hits, counter);
                }
            }
        }
    }
}

