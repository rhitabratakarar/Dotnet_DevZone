using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Interfaces
{
    internal interface ITodoElement
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Note { get; set; }
        public bool IsCompleted { get; set; }
    }
}
