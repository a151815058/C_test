using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//將字串轉換為 DateTime
namespace test_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            int[] redii = { 15, 32, 108, 74, 9 };
            const double pi = 3.14159;

            foreach (int radius in redii) {
                double circumference = pi * (2 * radius);
                Console.WriteLine("Radius of circle #{0} is {1}. Circumference = {2:N2}", counter, radius, circumference);
                counter++;
            }

            Console.ReadKey();
        }
    }
}
