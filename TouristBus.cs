using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TouristBus : Bus
    {
        /// <summary>
        /// Поле Стоимость экскурсии
        /// </summary>
        decimal excursionPrice;

        /// <summary>
        /// Свойство Стоимость экскурсии
        /// </summary>
        public decimal ExcursionPrice
        {
            get { return excursionPrice; }
            set
            {
                if(value < 0) excursionPrice = 0;
                else excursionPrice = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TouristBus() { }

        /// <summary>
        /// Конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="seats"></param>
        /// <param name="ticketPrice"></param>
        /// <param name="excursionPrice"></param>
        public TouristBus(string brand, int seats, decimal ticketPrice, decimal excursionPrice) : base(brand, seats, ticketPrice)
        {
            ExcursionPrice = excursionPrice;
        }

        /// <summary>
        /// Метод, выводящий 
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Марка: {Brand}\tКоличество мест: {Seats}\tСтоимость билета: {TicketPrice}\tСтоимоть экскурсии: {ExcursionPrice}");
        }

        /// <summary>
        /// Общая стоимость всех мест.
        /// </summary>
        /// <returns></returns>
        public override decimal TotalCost()
        {
            return Seats * (TicketPrice + ExcursionPrice);
        }
    }
}
