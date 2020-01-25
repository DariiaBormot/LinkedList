using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
 
    class DoublyLinkedList<T> : CustomList <T>
    {
         
        public override void Add(T item)
        {
            base.Add(item);
        }

        protected override Node<T> CreateNode(T item)
        {
            DoublyNode<T> node = new DoublyNode<T>(item);
            return node;
        }

        protected override void MoveTail(Node<T> node, Node<T> Tail)
        {
            base.MoveTail(node, Tail);
            ((DoublyNode<T>)node).PreviousElement = (DoublyNode<T>)Tail;
        }

        public override void Delete(T item)
        {
            base.Delete(item);
        }

        public override void DeleteMiddle(Node<T> current, Node<T> previous)
        {
            base.DeleteMiddle(current, previous);
            ((DoublyNode<T>)current).PreviousElement = (DoublyNode<T>)current.NextElement;
        }

        public IEnumerable<T> GetEnumeratorByDelegate(MyDelegate<T> getMethod)
        {     

            DoublyNode<T> current = (DoublyNode<T>)Head;

            while (current != null)
            {
                var startsFrom = getMethod?.Invoke(current.Item);

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
