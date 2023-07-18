using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Interfaces;

namespace Todo.Classes
{
    internal class TodolistModifier : ITodoListModifier
    {
        public void AddTodo(ITodoList todoList, ITodoElement todoToAdd)
        {
            todoList.ListOfTodos.Add(todoToAdd);
        }

        public void RemoveTodo(ITodoList todoList, ITodoElement todoToRemove)
        {
            todoList.ListOfTodos.Remove(todoToRemove);
        }
    }
}
