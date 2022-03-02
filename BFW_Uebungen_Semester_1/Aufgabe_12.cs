using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_12
    {
        public static void Start()
        {
            int[] numbers = new int[4] {70, 30, 89, 13};

            numbers[2] = 110;
            numbers[3] += 17;

            for (int i = 0; i<4; i++)
            {
                numbers[i] /= 5;
            }

            int[] newNumbers = new int[6];
            for (int i = 0; i<4; i++)
            {
                newNumbers[i] = numbers[i];
            }
            newNumbers[4] = 200; newNumbers[5] = 500;
            
            for (int i = 0; i<6; i++)
            {
                newNumbers[i] *= 2;
            }
            
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(i+1 + "tes Element: " + newNumbers[i]);
            }          
        }
    }
}