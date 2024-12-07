using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks = new();
    private int nextId = 1;

    public void AddTask(string description)
    {
        tasks.Add(new Task { Id = nextId++, Description = description, IsCompleted = false });
        Console.WriteLine("Task added successfully.");
    }

    public void ListTasks()
    {
        if (!tasks.Any())
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    public void UpdateTask(int id, bool isCompleted)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.IsCompleted = isCompleted;
            Console.WriteLine("Task updated successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public void DeleteTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }
}