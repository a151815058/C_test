using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LINQ轉換操作
namespace test_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant[] plants = new Plant[] {new CarnivorousPlant { Name = "Venus Fly Trap", TrapType = "Snap Trap" },
                                         new CarnivorousPlant { Name = "Pitcher Plant", TrapType = "Pitfall Trap" },
                                         new CarnivorousPlant { Name = "Sundew", TrapType = "Flypaper Trap" },
                                         new CarnivorousPlant { Name = "Waterwheel Plant", TrapType = "Snap Trap" } };

            var query = from CarnivorousPlant cPlant in plants
                        where cPlant.TrapType == "Snap Trap"
                        select cPlant;
            foreach (var ss in query) {
                Console.WriteLine("Name = {0} , Trap Type = {1}", ss.Name,ss.TrapType);
            }
            Console.ReadKey();
        }
       
    }
    class Plant
    {
        public string Name { get; set; }
    }
    class CarnivorousPlant : Plant {
        public string TrapType { get; set; }
    }
}
