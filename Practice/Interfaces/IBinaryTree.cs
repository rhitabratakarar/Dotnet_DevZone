using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces
{
    internal interface IBinaryTree
    {
        public IBinaryNode? Top { get; set; }
        public int InsertElement(IBinaryNode newNode);
        public int DeleteElement(int value);
        public int SearchElement(int value);
    }
}
