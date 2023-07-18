using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    internal interface ITodoListModifier
    {
        public void AddTodo(ITodoList todoList, ITodoElement todoToAdd);
        public void RemoveTodo(ITodoList todoList, ITodoElement todoToRemove);
    }
}
