using Practice.Interfaces;

namespace Practice.Classes
{
    internal class Node: INode
    {
        public int Value { get; set; }
        public INode? Next { get; set; } = null;

        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
