using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//在結構之間實作使用者定義的轉換 
namespace test_36
{
    struct RomanNumeral {
        private int value;
        public RomanNumeral(int value) { //先初始化RomanNumeral
            this.value = value;
        }
        static public implicit operator RomanNumeral(int value) {
            return new RomanNumeral(value);
        }
        static public implicit operator RomanNumeral(BinaryNumeral binary) {
            return new RomanNumeral((int)binary);
        }
        static public explicit operator int(RomanNumeral roman) {
            return roman.value;
        }
        static public explicit operator string(RomanNumeral roman) {
            return ("Conversion to string is not implemented");
        }
    }
    struct BinaryNumeral {
        private int value;
        public BinaryNumeral(int value) {
            this.value = value;
        }
        static public implicit operator BinaryNumeral(int value) {
            return new BinaryNumeral(value);
        }
        static public explicit operator int(BinaryNumeral binary) {
            return binary.value;
        }
        static public implicit operator string(BinaryNumeral binary) {
            return ("Conversion to string is not implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral roman;
            BinaryNumeral binary;

            roman = 10;

            binary = (BinaryNumeral)(int)roman;
            roman = binary;
            Console.WriteLine((int)binary);
            Console.WriteLine(binary);

            // Keep the console window open in debug mode.
            System.Console.ReadKey();
        }
    }
}
