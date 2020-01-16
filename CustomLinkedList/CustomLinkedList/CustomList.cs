using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class CustomList <T> : IEnumerable, ICustomList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public T this[int index] 
        { 
            get 
            {
                Node<T> current = Head;
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

        public CustomList (T item)
        {
            Node<T> node = new Node<T>(item);
            Head = node;
            Tail = node;
            Count = 1;
        }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);
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

        public void Delete(T item)
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
            Node<T> beforeHead = new Node<T>();
            beforeHead.NextElement = Head;

            return new CustomListIEnumerator<T>(beforeHead);
        }

    }
}
