using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public  class DoublyNode<T> : Node<T>
    {
        public DoublyNode<T> PreviousElement { get; set; }

        public DoublyNode(T item)
        {
            Item = item;
        }
        public DoublyNode()
        {
            Item = default(T);
        }
    }
}
