using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = InputBuses(2);
            List<TouristBus> touristBuses = InputTouristBuses(2);
           
            OutputBuses(buses);
            OutputTouristBuses(touristBuses);

            Console.ReadKey(true);
        }

        static List<Bus> InputBuses(int count)
        {
            List<Bus> buses = new List<Bus>();

            for(int i = 0; i < count; i++)
            {
                Console.Write("Марка: ");
                string brand = Console.ReadLine();
                Console.Write("Количество мест: ");
                int seats = int.Parse(Console.ReadLine());
                Console.Write("Стоимость билета: ");
                decimal ticketPrice = decimal.Parse(Console.ReadLine());
                buses.Add(new Bus(brand, seats, ticketPrice));
                Console.WriteLine();
            }

            return buses;
        }

        static List<TouristBus> InputTouristBuses(int count)
        {
            List<TouristBus> touristBuses = new List<TouristBus>();

            for (int i = 0; i < count; i++)
            {
                Console.Write("Марка: ");
                string brand = Console.ReadLine();
                Console.Write("Количество мест: ");
                int seats = int.Parse(Console.ReadLine());
                Console.Write("Стоимость билета: ");
                decimal ticketPrice = decimal.Parse(Console.ReadLine());
                Console.Write("Стоимость экскурсии: ");
                decimal excursionPrice = decimal.Parse(Console.ReadLine());
                touristBuses.Add(new TouristBus(brand, seats, ticketPrice, excursionPrice));
            }

            return touristBuses;
        }

        static void OutputBuses(List<Bus> buses)
        {
            foreach(Bus bus in buses)
            {
                bus.Print();
                Console.WriteLine($"Общая стоимость всех мест: {bus.TotalCost()}");
            }
        }

        static void OutputTouristBuses(List<TouristBus> buses)
        {
            foreach (TouristBus bus in buses)
            {
                bus.Print();
                Console.WriteLine($"Общая стоимость всех мест: {bus.TotalCost()}");
            }
        }
    }
}
