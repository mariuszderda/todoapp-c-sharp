using System;

namespace TodoApp
{
    public class App
    {
        public void run()
        {
            Task task = new Task();
            bool run = true;
            while (run)
            {
                Console.WriteLine("Wybierz opcje:");
                Console.WriteLine("1. Dodaj zadanie");
                Console.WriteLine("2. Usuń zadanie");
                Console.WriteLine("3. Wyświetl wszystkie zadanie");
                Console.WriteLine("4. Oznacz zadanie jako ukończone");
                Console.WriteLine("5. Wyjdź.");
                Console.Write("Twój wybór: ");
                string answer = Console.ReadLine();
                int intAnswer = int.Parse(answer);

                Console.WriteLine();
                switch (intAnswer)
                {
                    case 1:
                        task.AddTask();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Które zadanie chcesz usunąć.");
                        Console.WriteLine();
                        task.DisplayAllTasks();
                        string id = Console.ReadLine();
                        int idInt = Int32.Parse(id);
                        task.RemoveTask(idInt);
                        break;
                    case 3:
                        task.DisplayAllTasks();
                        break;
                    case 4:
                        Console.WriteLine("Które zadanie oznaczyć jako ukończone?");
                        string idCompletedTask = Console.ReadLine();
                        int intCompletedTask = int.Parse(idCompletedTask);
                        task.CompletedTasks(intCompletedTask);
                        break;
                    case 5:
                        Console.WriteLine("Do widzenia :)");
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wybierz właściwy numer.\n");
                        
                        break;
                }
            }
        }
    }
}