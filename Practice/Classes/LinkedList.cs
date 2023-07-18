using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Interfaces;

namespace Practice.Classes
{
    internal class LinkedList: ILinkedList
    {
        public INode? Head { get; set; } = null;
        public LinkedList(INode newNode)
        {
            this.Head = newNode;
        }
    }
}
