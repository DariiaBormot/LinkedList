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
        public Node<T> Head { get; protected set; }
        public Node<T> Tail { get; protected set; }
        public int Count { get; protected set; }

        public T this[int index] 
        { 
            get 
            {
                Node<T> current = Head;

                if (current != null)
                {
                    for (int j = 0; j < index; j++)
                        current = current.NextElement;
                    return current.Item;
                }
                return default(T);
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

        public virtual void Add(T item)
        {
            var node = CreateNode(item);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                MoveTail(node, Tail);
            }
            Tail = node;
            Count++;
        }

        protected virtual Node<T> CreateNode(T item )
        {
            Node<T> node = new Node<T>(item);
            return node;
        }

        protected virtual void MoveTail(Node<T> node, Node<T> Tail)
        {
            Tail.NextElement = node;
        }

   
        public virtual void Delete(T item)
        {
            var current = Head;
            var previous = current;

            while(current != null)
            {
                if (current.Item.Equals (item))
                {                  
                    if (current == Head)
                        Head = current.NextElement;
                    if (current == Tail)
                        Tail = previous;
                    if (current != Head && current != Tail)
                        DeleteMiddle(current, previous);
                    return;
                }
                previous = current;
                current = current.NextElement;
            }
        }

        public virtual void DeleteMiddle(Node <T> current, Node <T> previous)
        {
            previous.NextElement = current.NextElement;
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> beforeHead = new Node<T>();
            beforeHead.NextElement = Head;

            return new CustomListIEnumerator<T>(beforeHead);
        }

    }
}
