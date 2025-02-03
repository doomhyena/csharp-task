using System;
using System.Collections.Generic;

class Sulotion
{
    static void Main()
    {
        List<string> todoList = new List<string>();
        int userChoice;

        do
        {
            // Menu
            Console.Clear();
            Console.WriteLine("1. Új feladat hozzáadása");
            Console.WriteLine("2. Feladatok megjelenítése");
            Console.WriteLine("3. Feladat eltávolítása");
            Console.WriteLine("4. Kilépés");
            Console.Write("Válassz egy opciót: ");
            userChoice = GetValidInput();

            switch (userChoice)
            {
                case 1:
                    AddTask(todoList);
                    break;
                case 2:
                    DisplayTasks(todoList);
                    break;
                case 3:
                    RemoveTask(todoList);
                    break;
                case 4:
                    Console.WriteLine("Kilépés...");
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás! Próbáld újra.");
                    break;
            }
        } while (userChoice != 4);
    }

    static int GetValidInput()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Érvénytelen input, próbálj meg számot beírni: ");
        }
        return input;
    }

    static void AddTask(List<string> todoList)
    {
        Console.Write("Add meg az új feladatot: ");
        string task = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(task))
        {
            Console.WriteLine("A feladat nem lehet üres. Próbáld újra.");
        }
        else
        {
            todoList.Add(task);
            Console.WriteLine("Feladat hozzáadva!");
        }

        Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
        Console.ReadKey();
    }

    static void DisplayTasks(List<string> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("A lista üres.");
        }
        else
        {
            Console.WriteLine("Feladatok:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }

        Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
        Console.ReadKey();
    }

    static void RemoveTask(List<string> todoList)
    {
        DisplayTasks(todoList);

        if (todoList.Count > 0)
        {
            Console.Write("Add meg a törölni kívánt feladat számát: ");
            int taskNumber = GetValidInput();

            if (taskNumber < 1 || taskNumber > todoList.Count)
            {
                Console.WriteLine("Érvénytelen sorszám. Próbáld újra.");
            }
            else
            {
                todoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Feladat törölve!");
            }
        }

        Console.WriteLine("Nyomj meg egy billentyűt a folytatáshoz...");
        Console.ReadKey();
    }
}
