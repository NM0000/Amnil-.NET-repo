using System;
using System.Collections.Generic;

namespace Assignment_18_TaskQueueApp
{
    /// <summary>
    /// Represents a simple task queue system using a Queue.
    /// </summary>
    public class TaskQueue
    {
        private Queue<string> tasks = new Queue<string>();

        /// <summary>
        /// Adds a new task to the queue.
        /// </summary>
        /// <param name="task">The description of the task.</param>
        public void AddTask(string task)
        {
            tasks.Enqueue(task);
            Console.WriteLine($"Task Added: {task}");
        }

        /// <summary>
        /// Processes the next task in the queue.
        /// </summary>
        public void ProcessTask()
        {
            if (tasks.Count > 0)
            {
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"Processing Task: {currentTask}");
            }
            else
            {
                Console.WriteLine("All tasks completed!");
            }
        }

        /// <summary>
        /// Displays all pending tasks in the queue.
        /// </summary>
        public void ShowPendingTasks()
        {
            Console.WriteLine("\nPending Tasks:");
            if (tasks.Count == 0)
                Console.WriteLine("No pending tasks.");
            else
                foreach (var task in tasks)
                    Console.WriteLine(task);
        }
    }

    /// <summary>
    /// Main program demonstrating the Task Queue system using Queue.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Task Queue System ===\n");

            TaskQueue queue = new TaskQueue();
            queue.AddTask("Send email to client");
            queue.AddTask("Prepare meeting slides");
            queue.AddTask("Backup system files");

            queue.ShowPendingTasks();

            queue.ProcessTask();
            queue.ProcessTask();

            queue.ShowPendingTasks();
            queue.ProcessTask();
            queue.ProcessTask();
        }
    }
}
