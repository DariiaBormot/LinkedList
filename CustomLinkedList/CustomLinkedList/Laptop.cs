using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Laptop
    {
        public int serialNumber;
        public string Name;

        public Laptop(int SerialNumber, string Name)
        {
            serialNumber = SerialNumber;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
