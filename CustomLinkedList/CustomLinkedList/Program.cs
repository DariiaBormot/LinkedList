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
            var igor = new Laptop(1, "Igor");
            var lenovo = new Laptop(2, "Lenovo");
            var asus = new Laptop(3, "Asus");
            var aser = new Laptop(1, "Aser");
            var sumsung = new Laptop(2, "Sumsung");
            var dell = new Laptop(3, "Dell");

            CustomList laptopCollection = new CustomList();

            laptopCollection.Add(dell);
            laptopCollection.Add(igor);
            laptopCollection.Add(aser);
            laptopCollection.Add(lenovo);
            laptopCollection.Add(asus);
            laptopCollection.Add(sumsung);
            laptopCollection.Add(dell);

            laptopCollection.Delete(dell);
            laptopCollection.Delete(asus);

            Console.WriteLine(laptopCollection[2].Name);
            Console.WriteLine();

            foreach (var laptop in laptopCollection)
                Console.WriteLine(laptop);
            Console.ReadKey();
        }
    }
}
