using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Interfaces;

namespace Todo.Classes
{
    internal class TodoModifier : ITodoModifier
    {
        public void UpdateTodo(ITodoList todoList, ITodoElement todoToUpdate, ITodoElement updatedTodo)
        {
            throw new NotImplementedException();
        }
    }
}
