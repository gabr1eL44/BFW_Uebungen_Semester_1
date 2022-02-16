using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_7
    {
        public static void Start()
        {
            //string str1 = "wie", str2 = "dir", str3 = "es", str4 = "Danke", str5 = "Hallo", str6 = "geht", str7 = "gut", str8 = "mir";

            string[] words = { "wie", "dir", "es", "Danke", "Hallo", "geht", "gut", "mir" };

            /*
            string res1 = string.Format("{0}, {1} {2} {3} {4}?", str5, str1, str6, str3, str2);
            string res2 = string.Format("{0}, {1} {2} {3} {4}!", str4, str3, str6, str8, str7);
            */

            string res1 = string.Format("{0}, {1} {2} {3} {4}?", words[4], words[0], words[5], words[2], words[1]);
            string res2 = string.Format("{0}, {1} {2} {3} {4}!", words[3], words[2], words[5], words[7], words[6]);

            // Writing Strings on Console
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
