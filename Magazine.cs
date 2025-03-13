using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Magazine : Press
    {
        string quality;

        public string Quality { get => quality; set => quality = value; }

        public Magazine(int copies, string name, decimal price, string quality) : base(copies, name, price)
        {
            Quality = quality;
        }

        public override decimal Cost()
        {
            
        }

        public override void Output()
        {
            Console.WriteLine($"Кол-во копий: {Copies}\tНазвание: {Name}\tЦена: {Price}\tКачество: {Quality}");
        }
    }
}
