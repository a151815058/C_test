using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LINQ級聯
namespace test_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] cats =Getcat();
            Pet[] dogs =Getdog();
            IEnumerable<string> query = cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name));
            foreach (var e in query) {
                Console.WriteLine(e+" \n");
            }
            Console.ReadKey();

        }
        static Pet[] Getcat() {
            Pet[] cats = { new Pet { Name="Barley", Age=8 },
                           new Pet { Name="Boots", Age=4 },
                           new Pet { Name="Whiskers", Age=1 } };
            return cats;
        }
        static Pet[] Getdog() {
            Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                           new Pet { Name="Snoopy", Age=14 },
                           new Pet { Name="Fido", Age=9 }};
            return dogs;
        }
    }
    class Pet {
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}
