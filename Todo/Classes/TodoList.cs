using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Interfaces;

namespace Todo.Classes
{
    internal class TodoList : ITodoList
    {
        public IList<ITodoElement> ListOfTodos { get; set; }

        public TodoList()
        {
            this.ListOfTodos = new List<ITodoElement>();
        }
    }
}
