using System;
using System.Collections.Generic;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_X3
    {
        public static void Start()
        {
            List<int> listOfPrimes = new List<int>();

            listOfPrimes.Add(2);
            listOfPrimes.Add(3);
            listOfPrimes.Add(5);
            listOfPrimes.Add(7);
            listOfPrimes.Add(11);
            listOfPrimes.Add(13);
            listOfPrimes.Add(17);
            listOfPrimes.Add(19);
            listOfPrimes.Add(23);

            Console.WriteLine("Wie viele Mirpzahlen möchsten Sie erzeugen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            foreach (int possibleMirp in listofPrimes)
            {
                string str = Convert.ToString(possibleMirp);
                for (int i = (str.Length - 1); i >= 0; i--)
                    string newStr += str[i];

                int reversedInt = Convert.ToInt32(newStr);

                foreach (var prime in listOfPrimes)
                    if (prime == reversedInt)
                    {
                        Console.Write(prime + " ");
                        count++;
                        break;
                    }

                if (count == anzahl)
                    break;
            }
        }
    }
}

