using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computers> listCoputers = new List<Computers>()
            {
                new Computers() { Id = 1, Stamp = "HP", Processor = "Intel Core i7-7600U", Frequency = 2.8, RAM = 8, Hard_disk_memory= 1000, Video_card_memory = 3, Price = 1000, Availability =26 },
                new Computers() { Id = 2, Stamp = "Xiaomi", Processor = "Intel Core i7-7660U", Frequency = 2.5, RAM = 16, Hard_disk_memory= 1500, Video_card_memory = 6, Price = 999, Availability = 31 },
                new Computers() { Id = 3, Stamp = "Samsung", Processor = "Intel Core i7-7600U", Frequency = 2.5, RAM = 8, Hard_disk_memory= 500, Video_card_memory = 1, Price = 750, Availability = 29 },
                new Computers() { Id = 4, Stamp = "Dexp", Processor = "Intel Core i3-7100U", Frequency = 2.4, RAM = 4, Hard_disk_memory= 750, Video_card_memory = 1, Price = 655, Availability = 34 },
                new Computers() { Id = 5, Stamp = "Acer", Processor = "Intel Core i7-7500U", Frequency = 2.7, RAM = 16, Hard_disk_memory= 1250, Video_card_memory = 3, Price = 780, Availability = 9 },
                new Computers() { Id = 6, Stamp = "HP", Processor = "Intel Core i7-7600U", Frequency = 2.8, RAM = 16, Hard_disk_memory= 500, Video_card_memory = 6, Price = 1100, Availability = 3 },

            };
            Console.WriteLine("Введите название процессора");                                       //все компьютеры с указанным процессором
            string processor = Console.ReadLine();
            List<Computers> computers1 = listCoputers.Where(x=>x.Processor == processor).ToList();
            Console.WriteLine("Все компьютеры с указанным процессором ");
            Print(computers1);

            Console.WriteLine("Введите ОЗУ");                                                        //все компьютеры с объемом ОЗУ не ниже, чем указано
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computers> computers2 = listCoputers.Where(x => x.RAM >= ram).ToList();
            Console.WriteLine("Все компьютеры с объемом ОЗУ не ниже чем указано ");
            Print(computers2);

            List<Computers> computers3 = listCoputers.OrderBy(x => x.Price).ToList();                    //вывести весь список, отсортированный по увеличению стоимости
            Console.WriteLine("Сортировка по стоимости: ");
            Print(computers3);

            Console.WriteLine("Группировка по марке процессора: ");
            IEnumerable<IGrouping<string, Computers>> computers4 = listCoputers.GroupBy(x => x.Processor);   //группировка по процессорам 
            foreach (IGrouping<string, Computers> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computers c in gr)
                {
                    Console.WriteLine($"{c.Id} {c.Stamp} {c.Processor} {c.Frequency} {c.RAM} {c.Hard_disk_memory} {c.Video_card_memory} {c.Price} {c.Availability}");
                }
            }

            Console.WriteLine("Поиск самого дорогого компьютера: ");
            Computers computers5 = listCoputers.OrderBy(с => с.Price).FirstOrDefault();        //найти самый дорогой комп
            Console.WriteLine($"{computers5.Id} {computers5.Stamp} {computers5.Processor} {computers5.Frequency} {computers5.RAM} {computers5.Hard_disk_memory} {computers5.Video_card_memory} {computers5.Price} {computers5.Availability}");

            Console.WriteLine("Поиск самого дешового компьютера: ");
            Computers computers6 = listCoputers.OrderByDescending(с => с.Price).FirstOrDefault();        //найти самый бюджетный комп
            Console.WriteLine($"{computers5.Id} {computers5.Stamp} {computers5.Processor} {computers5.Frequency} {computers5.RAM} {computers5.Hard_disk_memory} {computers5.Video_card_memory} {computers5.Price} {computers5.Availability}");

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            if(listCoputers.Any(x => x.Availability > 200))
            {
                Console.WriteLine("Да есть");
            }
            else
                Console.WriteLine("Нет");
            Console.WriteLine(listCoputers.Any(x => x.Availability > 200));                                   //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.ReadKey();
        }
        static void Print(List<Computers> computers)
        {
            foreach (Computers c in computers)
            {
                Console.WriteLine($"{c.Id} {c.Stamp} {c.Processor} {c.Frequency} {c.RAM} {c.Hard_disk_memory} {c.Video_card_memory} {c.Price} {c.Availability}");
            }
        }
    }
}
