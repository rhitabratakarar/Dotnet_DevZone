using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces
{
    internal interface IBinaryNode
    {
        public int Value { get; set; }
        public IBinaryNode? Left { get; set; }
        public IBinaryNode? Right { get; set; }
    }
}
