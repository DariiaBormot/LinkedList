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

     

            var toshiba = new Laptop("Toshiba");
            var lenovo = new Laptop("Lenovo");
            var asus = new Laptop("Asus");
            var aser = new Laptop("Aser");
            var sumsung = new Laptop("Sumsung");
            var dell = new Laptop("Dell");

            //CustomList<Laptop> LaptopCollection = new CustomList<Laptop>();

            //LaptopCollection.Add(toshiba);
            //LaptopCollection.Add(lenovo);
            //LaptopCollection.Add(asus);
            //LaptopCollection.Add(aser);
            //LaptopCollection.Add(sumsung);
            //LaptopCollection.Add(dell);

            //LaptopCollection.Delete(toshiba);

            //Console.WriteLine(LaptopCollection[2]);
            //Console.WriteLine();

            //foreach (var laptop in LaptopCollection)
            //    Console.WriteLine(laptop);
            //Console.ReadKey();
            //Console.WriteLine();

            DoublyLinkedList<Laptop> NewLaptopCollection = new DoublyLinkedList<Laptop>();

            NewLaptopCollection.Add(toshiba);
            NewLaptopCollection.Add(lenovo);
            NewLaptopCollection.Add(asus);
            NewLaptopCollection.Add(aser);
            NewLaptopCollection.Add(sumsung);
            NewLaptopCollection.Add(dell);

            //foreach (var op in NewLaptopCollection)
            //    Console.WriteLine(op);
            //Console.WriteLine();

            NewLaptopCollection.Delete(toshiba);
            NewLaptopCollection.Delete(aser);
            NewLaptopCollection.Delete(dell);
            NewLaptopCollection.Delete(toshiba);

            foreach (var lapt in NewLaptopCollection)
                Console.WriteLine(lapt);

            Console.ReadKey();


        }
    }
}
