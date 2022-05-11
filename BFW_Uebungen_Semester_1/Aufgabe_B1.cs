using System;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_B1
    {
        public static void Start()
        {
            // Setting Encodings for € sign
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Bitte geben Sie den durchschnittlichen Einkaufspreis in Euro pro Quadratmeter ein: ");
            decimal einkPreis = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den durchschnittlichen Pachtpreis in Euro pro Quadratmeter ein: ");
            decimal vermPreis = Convert.ToDecimal(Console.ReadLine());

            decimal gewinn = vermPreis * 12;
            Console.WriteLine("Ihr Gewinn/Verlust nach x Jahren: 5: {0} €  10: {1} €  15: {2} €  20: {3} €", gewinn * 5 - einkPreis, gewinn * 10 - einkPreis, gewinn * 15 - einkPreis, gewinn * 20 - einkPreis);

            int jahre = (int)(einkPreis / (vermPreis * 12));
            int monate = (int)((einkPreis / (vermPreis * 12)) % 12);
            Console.WriteLine("\nSie werden die Gewinnschwelle nach {0} Jahren und {1} Monaten erreicht haben!", jahre, monate);
        }
    }
}
