using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//此運算子會從 Byte 型別轉換至名為 Digit 的數值型別
namespace test_35
{
    struct Digit {
        byte value;
        public Digit(byte value) {
            if (value > 9)
            {
                throw new System.ArgumentException();
            }
            this.value = value;
        }
        public static explicit operator Digit(byte b)  // explicit byte to digit conversion operator
        {
            Digit d = new Digit(b);  // explicit conversion

            System.Console.WriteLine("Conversion occurred.");
            return d;
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                byte b = 5;
                Digit d = (Digit)b;
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("{0} Exception caught.", e);
            }
            Console.ReadKey();
        }
    }
}
