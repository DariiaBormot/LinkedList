using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class CustomListIEnumerator : IEnumerator
    {
        private Node current;
        private Node head;

        public CustomListIEnumerator (Node node)
        {
            current = node;
            head = node;

        }
        public object Current { get { return current.Item; } }

        public bool MoveNext()
        {
            if (current.NextElement != null)
            {
                current = current.NextElement;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            current = head;
        }
    }
}
