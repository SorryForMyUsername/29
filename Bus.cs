using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bus
    {
        string brand;
        int seats;
        decimal ticketPrice;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value)) brand = "Остутствует";
                else brand = value;
            }
        }
        public int Seats
        {
            get { return seats; }
            set
            {
                if (value < 0) seats = 0;
                else seats = value;
            }
        }
        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set
            {
                if (value < 0) ticketPrice = 0;
                else ticketPrice = value;
            }
        }

        public Bus() { }

        public Bus(string brand, int seats, decimal ticketPrice)
        {
            Brand = brand;
            Seats = seats;
            TicketPrice = ticketPrice;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Марка: {Brand}\tКоличество мест: {Seats}\tСтоимость билета: {TicketPrice}");
        }

        public virtual decimal TotalCost()
        {
            return Seats * TicketPrice;
        }
    }
}
