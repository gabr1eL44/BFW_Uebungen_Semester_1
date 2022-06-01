using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_Y2
    {
        public static void Start()
        {
            Console.Write("Bitte geben Sie einen String ein: ");
            string str = Console.ReadLine();

            if (str != "")
            {
                while (true)
                {
                    Console.Write("Bitte geben Sie eine Zahl zwischen 1 und {0} ein: ", str.Length);
                    int position = Convert.ToInt32(Console.ReadLine());

                    string temp = "";
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (i == position - 1)
                            if (str[i] >= 'a')
                                temp += str[i].ToString().ToUpper();
                            else
                                temp += str[i].ToString().ToLower();
                        else
                            temp += str[i];
                    }
                    str = temp;
                    Console.WriteLine("\nIhr veränderter String lautet: " + str);
                }
            }
        }
    }
}
