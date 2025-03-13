using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Press
    {
        int copies;
        string name;
        decimal price;

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        public Press() { }

        public Press(int copies, string name, decimal price)
        {
            Copies = copies;
            Name = name;
            Price = price;
        }

        public virtual decimal Cost()
        {
            return Copies * Price;
        }

        public virtual void Output()
        {
            Console.WriteLine($"Кол-во копий: {Copies}\tНазвание: {Name}\tЦена: {Price}");
        }
    }
}
