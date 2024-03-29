﻿using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class DVG_2
    {
        public static double Calc(double a, double b)
        {
            Random rnd = new Random();
            double m = (double)rnd.Next(100) / 100;
            double s = (a + b) / 2;

            Console.WriteLine("Zufallszahl lautet : " + m);

            if (m < s)
            {
                Console.WriteLine("Zufallszahl kleiner!");
                s = a - b;
            }
            else
            {
                Console.WriteLine("Zufallszahl größer!");
                s = b - a;
            }

            if (s > 0)
                m = s;
            else
                m = -s;

            return m;
        }

        public static void Start()
        {
            double a = 0.2, b = 0.8;

            double ergebnis;

            while (true)
            {
                ergebnis = Calc(a, b);
                Console.WriteLine("Ihr Ergebnis lautet: " + ergebnis + "\n");
                Thread.Sleep(200);
            }
        }
    }
}
