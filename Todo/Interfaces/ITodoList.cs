using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    internal interface ITodoList
    {
        public IList<ITodoElement> ListOfTodos { get; set; }
    }
}
