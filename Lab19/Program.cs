using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{    class Door
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Cost { get; set; }
        public string Menufacture { get; set; }
        public string Material { get; set; }
        public List<string> Composition { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Door> listDoor = new List<Door>()
            {
                new Door(){Id=1, Width=1000, Height=2000,Cost=10000,Menufacture="Заря",Material="Металл", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли", "Глазок","Замок" } },
                new Door(){Id=1, Width=400, Height=1000,Cost=700,Menufacture="Красный луч",Material="Дерево", Composition= new List<string>(){"Полотно","Коробка","Ручка","Петли" } },
                new Door(){Id=1, Width=700, Height=1950,Cost=7200,Menufacture="Оконный завод",Material="Пластик", Composition= new List<string>(){"Полотно","Коробка" } },
                new Door(){Id=1, Width=1000, Height=2050,Cost=1500,Menufacture="Заветы Ильича",Material="Дерево", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли", "Глазок","Замок" } },
                new Door(){Id=1, Width=1100, Height=2000,Cost=1600,Menufacture="Заря",Material="Металл", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли", "Глазок","Замок" } },
                new Door(){Id=1, Width=800, Height=1900,Cost=900,Menufacture="Оконный завод",Material="Пластик", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли"} },
                new Door(){Id=1, Width=1500, Height=2500,Cost=11000,Menufacture="Восход",Material="Металл", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли", "Глазок" } },
                new Door(){Id=1, Width=900, Height=2100,Cost=6500,Menufacture="Красный луч",Material="Дерево", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли","Замок" } },
                new Door(){Id=1, Width=1200, Height=21000,Cost=1700,Menufacture="Заря",Material="Металл", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли", "Глазок","Замок" } },
                new Door(){Id=1, Width=1100, Height=1950,Cost=3000,Menufacture="Красный луч",Material="Дерево", Composition= new List<string>(){"Полотно","Коробка","Ручка", "Петли" } },
            };
            //List<Door> doors =(from d in listDoor
            //                          where d.Material == "Дерево"  SQL подобный
            //                          select d).ToList();
            //IEnumerable<Door> doors = listDoor
            //    .Where(d => d.Material == "Дерево");
            //    listDoor[1].Material = "Бетон"; - выражение не будет выполняться до перебора 
            List<Door> doors = listDoor
                .Where(d => d.Material == "Дерево")
                .ToList(); //Cинтаксис на основе методов расшиения.Выполняется немедленно.
            foreach (Door d in doors)
            {
                Console.WriteLine($"{d.Id} {d.Width} {d.Height} {d.Cost} {d.Menufacture} {d.Material}");
            }
            Console.ReadKey();
 
        }
    }
    //static class InExtension        Класс с мметодом расширения 
    //{
    //    public static int Add(this int v1,int v2)
    //    {
    //        return v1 + v2;
    //    }
    //}

}
