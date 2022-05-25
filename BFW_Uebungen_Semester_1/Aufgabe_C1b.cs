using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C1b
    {
        public static void Start()
        {
            string[,] variables = new string[,] { { "Celsius", "Kelvin" }, { "PS", "kW" }, { "Kalorien", "Joule" }, { "Dollar", "Euro" } };

            Console.WriteLine("[1] Umrechnen von {0} in {1}\n[2] Umrechnen von {2} in {3}\n[3] Umrechnen von {4} in {5}\n[4] Umrechnen von {6} in {7}",
                              variables[0, 0], variables[0, 1], variables[1, 0], variables[1, 1], variables[2, 0], variables[2, 1], variables[3, 0], variables[3, 1]);
            int mode = Convert.ToInt32(Console.ReadLine());

            double factor, offset = 0;
            switch (mode)
            {
                case 1:
                    factor = 1; offset = 273.15;
                    break;
                case 2:
                    factor = 0.735499;
                    break;
                case 3:
                    factor = 4.1868;
                    break;
                case 4:
                    factor = 0.94;
                    break;
                default:
                    return;                
            }

            Console.Clear();
            Console.WriteLine("[1] Umrechnen von {0} in {1}\n[2] Umrechnen von {1} in {0}", variables[mode - 1, 0], variables[mode - 1, 1]);
            int direction = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Bitte geben Sie die Größe in {0} ein: ", variables[mode - 1, direction - 1]);
            double input = Convert.ToInt32(Console.ReadLine());

            double output = Math.Round(direction == 1 ? factor * input + offset : input / factor - offset, 2);
            Console.WriteLine("{0} {1} sind genau {2} {3}.", input, variables[mode - 1, direction - 1], output, variables[mode - 1, direction % 2]);
        }
    }
}