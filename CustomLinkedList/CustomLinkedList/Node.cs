using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node
    {
        public Laptop Item { get; set; }

        public Node NextElement { get; set; }
        
        public Node (Laptop item)
        {
            Item = item;
        }
        public Node()
        {
            Item = null;
        }
    }
}
