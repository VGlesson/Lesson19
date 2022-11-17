using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Cod=1, Name="MSI", Type="Intel", Rate=120, VolumeO=6, VolumeD=512, VolumeV=4000, Price=600, Quantity=4},
                new Computer(){Cod=2, Name="Toshiba", Type="Intel", Rate=80, VolumeO=8, VolumeD=1124, VolumeV=6000, Price=400, Quantity=10},
                new Computer(){Cod=3, Name="Aser", Type="AMD", Rate=60, VolumeO=2, VolumeD=256, VolumeV=8000, Price=750, Quantity=7},
                new Computer(){Cod=4, Name="Asus", Type="AMD", Rate=60, VolumeO=4, VolumeD=512, VolumeV=1000, Price=350, Quantity=30},
                new Computer(){Cod=5, Name="HP", Type="Intel", Rate=140, VolumeO=12, VolumeD=126, VolumeV=4000, Price=500, Quantity=25},
                new Computer(){Cod=6, Name="Lenovo", Type="Intel", Rate=114, VolumeO=10, VolumeD=512, VolumeV=10000, Price=650, Quantity=50},
                new Computer(){Cod=7, Name="Apple", Type="M1", Rate=240, VolumeO=8, VolumeD=2248, VolumeV=12000, Price=1100, Quantity=5},
            };

            Console.WriteLine("Введите тип процессора");
            string type = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x=>x.Type == type).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем оперативной памяти");
            int volumeO = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.VolumeO == volumeO).ToList();
            Print(computers1);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Type);
            foreach(IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach(Computer e in gr)
                {
                    Console.WriteLine($"{e.Cod} {e.Name} {e.Type} {e.Rate} {e.VolumeO} {e.VolumeD} {e.VolumeV} {e.Price} {e.Quantity}");
                }
            }

            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Cod} {computer5.Name} {computer5.Type} {computer5.Rate} {computer5.VolumeO} {computer5.VolumeD} {computer5.VolumeV} {computer5.Price} {computer5.Quantity}");

            Computer computer6 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer6.Cod} {computer6.Name} {computer6.Type} {computer6.Rate} {computer6.VolumeO} {computer6.VolumeD} {computer6.VolumeV} {computer6.Price} {computer6.Quantity}");

            Console.WriteLine(computers.Any(x => x.Quantity > 30));

            Console.ReadKey();
        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{e.Cod} {e.Name} {e.Type} {e.Rate} {e.VolumeO} {e.VolumeD} {e.VolumeV} {e.Price} {e.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
