using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Num=1,Name="Иванов",Summa=100,City="Москва"},
                new Employee() {Num=1,Name="Петров",Summa=110,City="СПб"},
                new Employee() {Num=1,Name="Сидоров",Summa=60,City="Сочи"},
                new Employee() {Num=1,Name="Кузнецов",Summa=150,City="Иркутск"},
                new Employee() {Num=1,Name="Васильев",Summa=200,City="Москва"},
                new Employee() {Num=1,Name="Бендер",Summa=500,City="СПб"},
                new Employee() {Num=1,Name="Воробьянинонов",Summa=90,City="Сочи"},
                new Employee() {Num=1,Name="Балаганов",Summa=120,City="Екатеринбург"}
            };

            Console.WriteLine("Введите город");                                                     //Всех сотрудников из выбранного города 
            string city = Console.ReadLine();
            List<Employee> employees1 = employees.Where(x => x.City == city).ToList();
            Print(employees1);

            Console.WriteLine("Введите зп");                                                        //Все сотрудники с указанной или меньше чем указанна зп
            int summa = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees2 = employees.Where(x => x.Summa >= summa).ToList();
            Print(employees2);

            List<Employee> employees3 = employees.OrderBy(x => x.Name).ToList();                    //Сортировка имени в алфавитном порядке 
            Print(employees3);

            IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(x => x.City);   //Группировка по городам 
            foreach (IGrouping<string, Employee> gr in employees4)
            {
                Console.WriteLine(gr.Key);
                foreach (Employee e in gr)
                {
                    Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
                }
            }

            Employee employee5 = employees.OrderByDescending(e => e.Summa).FirstOrDefault();        //Сотрудник с самой большой зарплатой 
            Console.WriteLine($"{employee5.Num} {employee5.Name} {employee5.Summa} {employee5.City}");

            Console.WriteLine(employees.Any(x => x.Summa > 200));                                   //Есть ли хотя бы один сотрубник с зарплатой не ниже 200
            Console.ReadKey();

        }
        static void Print(List<Employee> employees)
        {
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{e.Num} {e.Name} {e.Summa} {e.City}");
            }
            Console.WriteLine();
        }
    }
}
