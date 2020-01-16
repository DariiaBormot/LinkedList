using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<object> ObjCollection = new CustomList<object>();


            ObjCollection.Add(1);
            ObjCollection.Add(2);
            ObjCollection.Add(3);
            ObjCollection.Add(4);
            ObjCollection.Add(5);
            ObjCollection.Add(6);

            ObjCollection.Delete(1);
            ObjCollection.Delete(5);

            Console.WriteLine(ObjCollection[2]);
            Console.WriteLine();

            foreach (var laptop in ObjCollection)
                Console.WriteLine(laptop);
            Console.ReadKey();
        }
    }
}
