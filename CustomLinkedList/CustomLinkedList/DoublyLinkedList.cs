using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
 
    class DoublyLinkedList<T> : CustomList <T>
    {
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public DoublyLinkedList (T data)
        {
            DoublyNode<T> node = new DoublyNode<T>();
            Head = node;
            Tail = node;
            Count++;
        }

        public override void Add(T item)
        {
            DoublyNode<T> node = new DoublyNode<T>(item); 
            if (Head != null)
            {
                node.PreviousElement = Tail;
                base.Add(item);
            }
            else 
            base.Add(item);
        }

        public override void Delete(T item)
        {
            
            var current = Head;
            var previous = current;
            while (current != null)
            {
                if (current.Item.Equals (item))
                {
                    previous.NextElement = current.NextElement;
                    current.PreviousElement = current.NextElement;
                    if (current == Head)
                    {
                        base.Delete(item);
                    }
                    if (current == Tail)
                    {
                        base.Delete(item);
                    }
                    return;
                }
                previous = current;
                current = current.NextElement;
            }
            
        }

        public IEnumerable<T> GetByDelegate(MyDelegate<T> del)
        {
            DoublyNode<T> current = new DoublyNode<T>();
            current = (DoublyNode<T>)Head;

            while (current != null)
            {
                var startsFrom = del?.Invoke(current.Item);

                if (startsFrom == true)
                {
                    yield return current.Item;
     
                }
                current = (DoublyNode<T>)current.NextElement;
            }

        }

        public delegate bool MyDelegate<U>(U laptop);

        MyDelegate<Laptop> getMethod = new MyDelegate<Laptop>(NameStartsFrom);

        public static bool NameStartsFrom(Laptop laptop)
        {
            var name = laptop.Name;
           
            if (name[0].Equals ("a"))
             return true; 
            else
             return false;
        }

    }
}
