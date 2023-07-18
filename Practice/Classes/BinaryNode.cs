using Practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    internal class BinaryNode : IBinaryNode
    {
        public int Value { get; set; }
        public IBinaryNode? Left { get; set; } = null;
        public IBinaryNode? Right { get; set; } = null;

        public BinaryNode(int value)
        {
            this.Value = value;
        }
    }
}
