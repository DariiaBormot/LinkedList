using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class CustomList : IEnumerable, ICustomList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }

        public Laptop this[int index] 
        { 
            get 
            {
                Node current = Head;
                for (int j = 0; j < index; j++)
                    current = current.NextElement;
                return current.Item;
            }
        }

        public CustomList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public CustomList (Laptop item)
        {
            Node node = new Node(item);
            Head = node;
            Tail = node;
            Count = 1;
        }

        public void Add(Laptop item)
        {
            Node node = new Node(item);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.NextElement = node;
                Tail = node;
            }
            Count++;
        }

        public void Delete(Laptop item)
        {
           if (Head != null)
            {
                if (Head.Item.Equals (item))
                {
                    Head = Head.NextElement;
                    Count--;
                    return;
                }
                var current = Head.NextElement;
                var previous = Head;
                while (current != null)
                {
                    if (current.Item.Equals (item))
                    {
                        previous.NextElement = current.NextElement;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.NextElement;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            Node beforeHead = new Node();
            beforeHead.NextElement = Head;

            return new CustomListIEnumerator(beforeHead);
        }
       
    }
}
