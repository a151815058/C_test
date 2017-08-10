using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//如何使用 TryParse 與 long、byte 及 decimal 值的字串表示
namespace test_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string numString = "1287543";
            long number1 = 0;
            bool canConvert = long.TryParse(numString, out number1);

            if (canConvert == true) {
                Console.WriteLine("number1 now = {0}", number1);
            }
            else {
                Console.WriteLine("numString is not a valid long");
            }

            byte number2 = 0;
            numString = "255";
            canConvert = byte.TryParse(numString, out number2);
            if (canConvert == true)
            {
                Console.WriteLine("number1 now = {0}", number2);
            }
            else
            {
                Console.WriteLine("numString is not a valid long");
            }
            decimal number3 = 0;
            numString = "27.5";
            canConvert = decimal.TryParse(numString,out number3);
            if(canConvert == true)
            {
                Console.WriteLine("number1 now = {0}", number3);
            }
            else
            {
                Console.WriteLine("numString is not a valid long");
            }

            Console.ReadKey();
        }
    }
}
