using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces
{
    public interface INode
    {
        public INode? Next { get; set; }
        public int Value { get; set; }
    }
}
