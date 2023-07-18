using Practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes
{
    internal class BinaryTree : IBinaryTree
    {
        public IBinaryNode? Top { get; set; } = null;

        public BinaryTree(IBinaryNode top)
        {
            this.Top = top;
        }

        public int InsertElement(IBinaryNode newNode)
        {
            throw new NotImplementedException();
        }

        public int DeleteElement(int value)
        {
            throw new NotImplementedException();
        }

        public int SearchElement(int value)
        {
            throw new NotImplementedException();
        }
    }
}
