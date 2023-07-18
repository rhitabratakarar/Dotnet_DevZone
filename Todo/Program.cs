using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Todo.Classes;
using Todo.Interfaces;

class Program
{
    static void ShowInstructions()
    {
        Console.WriteLine("2 to Show all todo.");
        Console.WriteLine("3 to Add a new Todo.");
        Console.WriteLine("4 to Delete a todo.");
        Console.WriteLine("5 to Update a todo.");
        Console.WriteLine("0 to Exit the program.");
    }

    public static void Main()
    {
        int? operation = null;
        ITodoList todoList = new TodoList();
        ITodoListModifier todoListModifier = new TodolistModifier();
        ITodoModifier todoModifier = new TodoModifier();

        while (operation != 0)
        {
            Console.WriteLine("1 to show the instructions.");
            Console.Write("Enter the operation you want to take: ");
            operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
                ShowInstructions();
            else if (operation == 2)
            {
                foreach (ITodoElement todo in todoList.ListOfTodos)
                {
                    Console.WriteLine(todo.ToString());
                }
            }
            else if (operation == 3)
            {
                Console.Write("Enter the Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter the Note: ");
                string notes = Console.ReadLine()!;
                Console.Write("Is it Completed? (true/false): ");
                bool isCompleted = Convert.ToBoolean(Console.ReadLine());
                todoListModifier.AddTodo(todoList, new TodoElement(new Random().Next(), name, notes, isCompleted));
            }
            else if (operation == 4)
            {
                Console.Write("Enter the ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                ITodoElement todoToRemove = todoList.ListOfTodos.Where((t) => t.Id == id).ToList()[0];
                todoList.ListOfTodos.Remove(todoToRemove);
            }
            else if (operation == 5)
            {
                Console.Write("Enter the ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                ITodoElement todoToUpdate = todoList.ListOfTodos.Where((t) => t.Id == id).ToList()[0];

                Console.Write("Enter the Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter the Note: ");
                string notes = Console.ReadLine()!;
                Console.Write("Is it Completed? (true/false): ");
                bool isCompleted = Convert.ToBoolean(Console.ReadLine());

                todoToUpdate.Name = name;
                todoToUpdate.Note = notes;
                todoToUpdate.IsCompleted = isCompleted;
            }
            else if (operation == 0)
                break;
            else
                Console.WriteLine("Wrong operation. Show 1 to view the operations available");
        }
    }
}



