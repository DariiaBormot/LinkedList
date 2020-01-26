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

        public IEnumerable<T> GetEnumeratorByDelegate(MyDelegate<T> del)
        {     

            DoublyNode<T> current = (DoublyNode<T>)Head;

            while (current != null)
            {
                var validate = del?.Invoke(current.Item);

                if (validate == true)
                {
                    yield return current.Item;
     
                }
                current = (DoublyNode<T>)current.NextElement;
            }
        }


        public delegate bool MyDelegate<T>(T item);

        MyDelegate<T> getMethod = new MyDelegate<T>(IsNull);

        public static bool IsNull(T item)
        {
            if (item != null)
                return true;
            else
                return false;
        }

    }
}
