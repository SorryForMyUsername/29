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

        public int Copies
        {
            get { return copies; }
            set
            {
                if(value < 0) copies = 0;
                else copies = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if(String.IsNullOrEmpty(value)) name = "Неизвестно";
                else name = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if(value < 0) price = 0;
                else price = value;
            }
        }

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
