using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Press> presses = InputPress(2);
            OutputPress(presses);
            Console.WriteLine();

            List<Magazine> magazines1 = InputMagazine(2);
            OutputMagazines(magazines1);
            Console.WriteLine();

            List<Press> magazines2 = MagazineListInPressList(InputMagazine(2));
            OutputPress(magazines2);

            Console.ReadKey();
        }

        static List<Press> InputPress(int count)
        {
            List<Press> presses = new List<Press>();

            for(int i = 0; i < count; i++)
            {
                Console.Write("Копии: ");
                int copies = int.Parse(Console.ReadLine());
                Console.Write("Название: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                decimal price = decimal.Parse(Console.ReadLine());
                presses.Add(new Press(copies, name, price));
                Console.WriteLine();
            }

            return presses;
        }

        static List<Magazine> InputMagazine(int count)
        {
            List<Magazine> magazines = new List<Magazine>();

            for (int i = 0; i < count; i++)
            {
                Console.Write("Копии: ");
                int copies = int.Parse(Console.ReadLine());
                Console.Write("Название: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Качество: ");
                string quality = Console.ReadLine();
                magazines.Add(new Magazine(copies, name, price, quality));
                Console.WriteLine();
            }

            return magazines;
        }

        static void OutputPress(List<Press> presses)
        {
            foreach(Press press in presses)
            {
                press.Output();
                Console.WriteLine($"Общая стоимость всех мест: {press.Cost()}");
            }
        }

        static void OutputMagazines(List<Magazine> magazines)
        {
            foreach (Magazine magazine in magazines)
            {
                magazine.Output();
                Console.WriteLine($"Общая стоимость всех мест: {magazine.Cost()}");
            }
        }

        static List<Press> MagazineListInPressList(List<Magazine> magazines)
        {
            List<Press> presses = new List<Press>();

            foreach(Magazine magazine in magazines)
            {
                presses.Add(magazine);
            }

            return presses;
        }
    }
}
