public class Program
{

    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Task Manager ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Click only numbers!\nClick the Enter for continue...");
                    Console.ReadLine();
                    break;
            }
        }

    }
    static void AddTask()
    {
        Console.Write("\nNew task title: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("\nTask added successfully.\nClick the Enter...");
        Console.ReadLine();
    }

    static bool ViewTasks()
    {
        Console.WriteLine("\n=== Current Tasks ===");
        bool result = false;
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nHere are no tasks yet.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            result = true;
        }
        Console.Write("\nClick the Enter for continue...");
        Console.ReadLine();
        return result;
    }

    static void RemoveTask()
    {
        if (!ViewTasks())
            return;
        Console.WriteLine("\nSelect the task number you will remove: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            if (index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("\nTask removed successfully!");
            }
            else
            {
                Console.WriteLine("\nInvalid task number!!!");
            }
        }
        else
        {
            Console.WriteLine("\nEnter only numbers!!!");
        }
        Console.Write("\nClick the Enter for continue...");
        Console.ReadLine();
    }
}

