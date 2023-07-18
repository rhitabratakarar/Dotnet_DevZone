using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    internal interface ITodoModifier
    {
        public void UpdateTodo(ITodoList todoList, ITodoElement todoToUpdate, ITodoElement updatedTodo);
    }
}
