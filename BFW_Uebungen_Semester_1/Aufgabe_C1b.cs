using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_C1b
    {
        public static void Start()
        {
            string[,] variables = new string[,] { { "Celsius", "Kelvin" }, { "PS", "kW" }, { "Kalorien", "Joule" }, { "Dollar", "Euro" } };

            Console.WriteLine("[1] Umrechnen von {0} in {1}\n[2] Umrechnen von {2} in {3}\n[3] Umrechnen von {4} in {5}\n[4] Umrechnen von {6} in {7}",
                              variables[0,0], variables[0,1], variables[1,0], variables[1,1], variables[2,0], variables[2,1], variables[3,0], variables[3,1]);

            int convertMode = Convert.ToInt32(Console.ReadLine());

            double convertFactor, offset = 0;
            switch (convertMode)
            {
                case 1:
                    convertFactor = 1; offset = 273.15;
                    break;
                case 2:
                    convertFactor = 1 / 1.35962;
                    break;
                case 3:
                    convertFactor = 4.1868;
                    break;
                case 4:
                    convertFactor = 0.94;
                    break;
                default:
                    return;                
            }

            Console.WriteLine("[1] Umrechnen von {0} in {1}\n[2] Umrechnen von {1} in {0}", variables[convertMode -1, 0], variables[convertMode - 1, 1]);
            int convertDirection = Convert.ToInt32(Console.ReadLine());

            
            if (convertDirection == 1)
            {
                Console.WriteLine("\nBitte geben Sie die Größe {0} ein: ", variables[convertMode - 1, 0]);
                double input = Convert.ToInt32(Console.ReadLine());

                double output = convertFactor * input + offset;
                Console.WriteLine("{0} {1} sind genau {2} {3}.", input, variables[convertMode - 1, 0], output, variables[convertMode - 1, 1]);
            }
            else if (convertDirection == 2)
            {
                Console.WriteLine("\nBitte geben Sie die Größe {0} ein: ", variables[convertMode - 1, 1]);
                double input = Convert.ToInt32(Console.ReadLine());

                double output = input / convertFactor - offset;
                Console.WriteLine("{0} {1} sind genau {2} {3}.", input, variables[convertMode - 1, 1], output, variables[convertMode - 1, 0]);
            }
        }
    }
}