using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node <T>
    {
        public T Item { get; set; }

        public Node<T> NextElement { get; set; }

        public Node (T item)
        {
            Item = item;
        }
        public Node()
        {
            Item = default(T);
        }
    }
}
