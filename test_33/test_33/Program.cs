using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intersect(相交)例子- Enumerable.Intersect方法
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };
            IEnumerable<int> query = id1.Intersect(id2);//只取出兩個陣列相交的部分
            foreach (int ss in query) {
                Console.WriteLine(ss);
            }

            //Union例子- Enumerable.Union方法
            int[] idd1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] idd2 = { 8, 3, 6, 4, 4, 9, 1, 0 };
            IEnumerable<int> query1 = idd1.Union(idd2);
            foreach (int sss in query1) {
                Console.WriteLine(sss+"----");
            }
            //SequenceEqual例子 - Enumerable.SequenceEqual方法
            Pet barley = new Pet() { Name = "barley",Age = 4 };
            Pet boots = new Pet() { Name = "boots ", Age = 1 };
            Pet whiskers = new Pet() { Name = "whiskers  ", Age = 6 };
            List<Pet> pet1 = new List<Pet> { barley, boots };
            List<Pet> pet2 = new List<Pet> { barley, boots };
            List<Pet> pet3 = new List<Pet> { barley, boots, whiskers };
            bool equal = pet1.SequenceEqual(pet2);
            bool equa2 = pet1.SequenceEqual(pet3);

            Console.WriteLine("The lists pets1 and pets2 {0} equal.", equal ? "are" : "are not");
            Console.WriteLine("The lists pets1 and pets3 {0} equal.", equa2 ? "are" : "are not");

            Console.ReadKey();
        }
    }
    class Pet {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
