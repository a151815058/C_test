using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_32
{
    class Program
    {
        static void Main(string[] args)
        {

            //DefaultIfEmpty例子 - Enumerable.DefaultIfEmpty.Method
            Pet barley = new Pet() {Name = "Barley", Age = 4 };
            Pet boots = new Pet() { Name = "boots", Age = 1 };
            Pet whiskers = new Pet() { Name = "whiskers", Age = 6 };
            Pet bluemoon = new Pet() { Name = "bluemoon", Age = 9 };
            Pet daisy = new Pet() { Name = "daisy", Age = 3 };
            Pet nono = new Pet() { Name ="", Age = 4};
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy , nono };
            foreach (var ss in pets.DefaultIfEmpty()) {
                Console.WriteLine("Name = {0} ", ss.Name);
            }
           

            //Range例子- Enumerable.Range方法
            IEnumerable<int> sqaure = Enumerable.Range(1, 5).Select(x => x * x);
            foreach (int i in sqaure) {
                Console.WriteLine("Name = {0} ", i);
            }

            //Except例子 - Enumerable.Except方法
            double[] num1 = { 2.0, 2.1, 2.2, 2.3, 2.4, 2.5 };
            double[] num2 = { 2.2 };
            IEnumerable<double> onlyInFirstSet = num1.Except(num2);//列出num1陣列裡的小數，扣除掉跟num2一樣的數字
            foreach (double i in onlyInFirstSet) {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
    class Pet {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
