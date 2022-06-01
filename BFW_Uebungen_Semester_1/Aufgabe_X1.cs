using System;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_X1
    {
        public static void Start()
        {
            string[] memories = new string[0];
            string[] delMemories = new string[0];
            
            int counter = 0, delCounter = 0;

            string input;
            while (true)
            {
                Console.WriteLine("===========");
                Console.WriteLine("To-Do Liste");
                Console.WriteLine("===========");

                Console.WriteLine("(1) Hinzufügen einer Erinnerungen");
                Console.WriteLine("(2) Anzeigen aller Erinnerungen");
                Console.WriteLine("(3) Anzeigen aller gelöschten Erinnerungen");
                Console.WriteLine("(4) Tauschen von Erinnerungen");
                Console.WriteLine("(5) Löschen einer Erinnerungen");
                Console.WriteLine("(x) Programm beenden");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Bitte geben Sie die neue Erinnerung ein:");
                        Console.Write("{0}: ", counter);
 
                        string[] tempArr = new string[memories.Length + 1];
                        for (int i = 0; i < counter; i++)
                            tempArr[i] = memories[i];
                        tempArr[tempArr.Length - 1] = Console.ReadLine();
                        memories = tempArr;

                        counter++;
                        break;
                    case "2":
                        Console.Clear();
                        if (counter != 0)
                        {
                            Console.WriteLine("Ihre gespeicherten Erinnerung:");
                            for (int i = 0; i < counter; i++)
                                Console.WriteLine("{0}: {1}", i, memories[i]);
                        }
                        else
                            Console.WriteLine("Sie haben keine Erinnerungen gespeichert!");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        if (delCounter != 0)
                        {
                            Console.WriteLine("Ihre gelöschten Erinnerung:");

                            for (int i = 0; i < delCounter; i++)
                                Console.WriteLine("{0}: {1}", i, delMemories[i]);
                        }
                        else
                            Console.WriteLine("Sie haben noch keine Erinnerungen gelöscht!");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        if (counter >= 2)
                        {
                            Console.WriteLine("Bitte geben Sie den ersten Index ein (0-{0}):", counter - 1);
                            if ((Int32.TryParse(Console.ReadLine(), out int firstIndex) && (firstIndex > -1) && (firstIndex < counter))) 
                            {
                                Console.WriteLine("Bitte geben Sie den zweiten Index ein (0-{0}):", counter - 1);
                                if ((Int32.TryParse(Console.ReadLine(), out int secondIndex) && (secondIndex > -1) && (secondIndex < counter))) 
                                {
                                    string temp = memories[firstIndex];
                                    memories[firstIndex] = memories[secondIndex];
                                    memories[secondIndex] = temp;
                                }
                                else
                                {
                                    Console.WriteLine("Fehlerhafte Eingabe!");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fehlerhafte Eingabe!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sie haben zu wenig Erinnerungen zum Tauschen!");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Console.Clear();
                        if (counter != 0)
                        {
                            Console.WriteLine("\nWelche Erinnerung möchten Sie löschen (0-{0})?", counter - 1);

                            if ((Int32.TryParse(Console.ReadLine(), out int index)) && (index > -1) && (index < counter))
                            {
                                string[] tempArr2 = new string[delMemories.Length + 1];
                                for (int i = 0; i < delCounter; i++)
                                    tempArr2[i] = delMemories[i];
                                tempArr2[tempArr2.Length - 1] = memories[index];
                                delMemories = tempArr2;

                                int skipped = 0;
                                string[] tempArr3 = new string[memories.Length - 1];
                                for (int i = 0; i < counter - 1; i++)
                                {
                                    if (index == i)
                                        skipped = 1;
                                    tempArr3[i] = memories[i + skipped];
                                }
                                memories = tempArr3;

                                counter--; delCounter++;
                            }
                            else
                            {
                                Console.WriteLine("Fehlerhafte Eingabe!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sie können keine Erinnerungen löschen!");
                            Console.ReadKey();
                        }
                        break;
                    case "x":
                        return;
                }
                Console.Clear();
            }
        }
    }
}
