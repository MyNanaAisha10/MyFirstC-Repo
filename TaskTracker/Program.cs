using System;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nTask Tracker CLI");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. List Tasks");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();
                    taskManager.AddTask(description);
                    break;

                case "2":
                    taskManager.ListTasks();
                    break;

                case "3":
                    Console.Write("Enter task ID to update: ");
                    int updateId = int.Parse(Console.ReadLine());
                    Console.Write("Is the task completed? (yes/no): ");
                    string isCompletedInput = Console.ReadLine();
                    bool isCompleted = isCompletedInput.Equals("yes", StringComparison.OrdinalIgnoreCase);
                    taskManager.UpdateTask(updateId, isCompleted);
                    break;

                case "4":
                    Console.Write("Enter task ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    taskManager.DeleteTask(deleteId);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}


