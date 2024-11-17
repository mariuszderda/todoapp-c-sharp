using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp
{
    public class Task
    {
        private List<Item> Tasks = new List<Item>();
        private int taskId = 1;

        public void AddTask()
        {
            Console.Write("Zadanie do wykonanaia: ");
            string title = Console.ReadLine();
            
            Item newTask = new Item(taskId, title);
            Tasks.Add(newTask);

            Console.WriteLine($"Dodano zadanie.");
            taskId++;
            Console.WriteLine();
        }

        public void DisplayAllTasks()
        {
            foreach (var task in Tasks)
            {
                Console.WriteLine(task);
            }
        }

        private int FindTask(int id)
        {
            int index = Tasks.FindIndex(r => r.Id == id);
            return index;
        }

        public void RemoveTask(int id)
        {
            int index = FindTask(id);
            if (index != -1)
            {
                Tasks.RemoveAt(index);
                Console.WriteLine("Zadanie usunięte");    
            }
            else
            {
                Console.WriteLine("Brak numeru zadania w bazie.");
            }
            
        }

        public void CompletedTasks(int id)
        {
            int index = FindTask(id);
            if (index != -1)
            {
                Tasks[index].Completed = true;
                Console.WriteLine($"Zadanie {index} zostało oznaczone.");

            }
            else
            {
                Console.WriteLine("Brak zadania do oznaczenia jako ukończone.");
            }
        }
    }
}