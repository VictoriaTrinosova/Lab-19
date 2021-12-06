using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_19
{
    class Computer
    {
        public int code { get; set; }
        public string brandName { get; set; }
        public string typeProcessor { get; set; }
        public int frequencyProcessor { get; set; }
        public int amountRAM { get; set; }
        public int volumeHarddisk { get; set; }
        public int memoryVideocard { get; set; }
        public int costComputer  { get; set; }
        public int numberCopies { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComputer = new List<Computer>()
            {
             new Computer() {code=4764, brandName= "Apple", typeProcessor= "Pentium", frequencyProcessor=3, amountRAM=800, volumeHarddisk=1000,memoryVideocard=600, costComputer=650, numberCopies=34},
             new Computer() {code=4763, brandName= "HP", typeProcessor= "Deschutes", frequencyProcessor=2, amountRAM=700, volumeHarddisk=800,memoryVideocard=500, costComputer=530, numberCopies=2},
             new Computer() {code=4976, brandName= "ASUS", typeProcessor= "Tonga", frequencyProcessor=1, amountRAM=600, volumeHarddisk=700,memoryVideocard=400, costComputer=420, numberCopies=9},
             new Computer() {code=9768, brandName= "Apple", typeProcessor= "Pentium", frequencyProcessor=3, amountRAM=800, volumeHarddisk=1000,memoryVideocard=600, costComputer=600, numberCopies=6},
             new Computer() {code=3365, brandName= "ASUS", typeProcessor= "Tonga", frequencyProcessor=1, amountRAM=600, volumeHarddisk=700,memoryVideocard=400, costComputer=420, numberCopies=3},
             new Computer() {code=7976, brandName= "Apple", typeProcessor= "Pentium", frequencyProcessor=3, amountRAM=800, volumeHarddisk=1000,memoryVideocard=600, costComputer=610, numberCopies=7},
             new Computer() {code=1346, brandName= "HP", typeProcessor= "Deschutes", frequencyProcessor=2, amountRAM=700, volumeHarddisk=800,memoryVideocard=500, costComputer=540, numberCopies=1},
             new Computer() {code=3866, brandName= "DELL", typeProcessor= "Celeron", frequencyProcessor=3, amountRAM=800, volumeHarddisk=1000,memoryVideocard=600, costComputer=670, numberCopies=3},
            };
            //string a = Console.ReadLine();
            //List<Computer> comp = listComputer
            //    .Where(t => t.typeProcessor == a)
            //    .ToList();
            //foreach (Computer t in comp)
            //    Console.WriteLine($"{t.code} {t.brandName} {t.typeProcessor} {t.frequencyProcessor} {t.amountRAM} {t.volumeHarddisk} {t.memoryVideocard} {t.costComputer} {t.numberCopies}");
            //Console.ReadKey();
            //int b = Convert.ToInt32(Console.ReadLine());
            //List<Computer> comp1 = listComputer
            //    .Where(y => y.amountRAM <= b)
            //    .ToList();
            //foreach (Computer y in comp1)
            //    Console.WriteLine($"{y.code} {y.brandName} {y.typeProcessor} {y.frequencyProcessor} {y.amountRAM} {y.volumeHarddisk} {y.memoryVideocard} {y.costComputer} {y.numberCopies}");
            //Console.ReadKey();
            //List<Computer> comp2 = listComputer
            //   .OrderBy(y => y.costComputer)
            //   .ToList();
            //foreach (Computer y in comp2)
            //    Console.WriteLine($"{y.code} {y.brandName} {y.typeProcessor} {y.frequencyProcessor} {y.amountRAM} {y.volumeHarddisk} {y.memoryVideocard} {y.costComputer} {y.numberCopies}");
            //Console.ReadKey();
            //var computerGroups= listComputer.GroupBy(y => y.typeProcessor);
            //foreach (IGrouping<string, Computer> g in computerGroups)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach (var y in g)
            //        Console.WriteLine($"{y.code} {y.brandName} {y.frequencyProcessor} {y.amountRAM} {y.volumeHarddisk} {y.memoryVideocard} {y.costComputer} {y.numberCopies}");
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //var max = listComputer.Max(m => m.costComputer);
            //Console.WriteLine($"Максимальная цена: {max}");
            //var min = listComputer.Min(m => m.costComputer);
            //Console.WriteLine($"Минимальная цена: {min}");
            bool result1 = listComputer.Any(u => u.numberCopies>=30);
            if (result1)
                Console.WriteLine("Есть хотя бы один компьютер в количестве не менее 30 штук");
            else
                Console.WriteLine("Количество всех компьютеров меньше 30 штук");


        }

    }
}
