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

        public string Quality
        {
             
            get { return quality; }
            set
            {
                if(value != "высокое" && value != "низкое")
                {
                    quality = "среднее";
                }
                else quality = value;
            }
        }

        public Magazine(int copies, string name, decimal price, string quality) : base(copies, name, price)
        {
            Quality = quality;
        }

        public override decimal Cost()
        {
            decimal qualityMultiplier;
            switch (quality)
            {
                case "высокое":
                    qualityMultiplier = 1.1M;
                    break;
                case "среднее":
                    qualityMultiplier = 1M;
                    break;
                case "низкое":
                    qualityMultiplier = 0.9M;
                    break;
                default:
                    qualityMultiplier = 1M;
                    break;
            }

            return base.Cost() * qualityMultiplier;
        }

        public override void Output()
        {
            Console.WriteLine($"Кол-во копий: {Copies}\tНазвание: {Name}\tЦена: {Price}\tКачество: {Quality:N0}");
        }
    }
}
