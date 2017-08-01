using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//比較字串
//當程式宣告兩個或多個相同的字串變數時，編譯器會將它們全部儲存在相同的位置,所以使用equals時會回傳true
//但是如果使用了copy物件時，就不會被放相同的位置了
namespace test_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Internal strings that will never be localized.
            string root1 = @"C:\users";
            string root2 = @"C:\Users";

            bool result = root1.Equals(root2 ,StringComparison.Ordinal);
            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", root1, root2,
                    result ? "equal." : "not equal.");
            Console.ReadKey();

            // To ignore case means "user" equals "User". This is the same as using
            // String.ToUpperInvariant on each string and then performing an ordinal comparison.
            bool result2 = root1.Equals(root2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", root1, root2,
                    result2 ? "equal." : "not equal.");
            Console.ReadKey();

            // A static method is also available.
            bool areEqual = String.Equals(root1, root2,StringComparison.Ordinal);
            Console.WriteLine("Ordinal comparison: {0} and {1} are {2}", root1, root2,
                    areEqual ? "equal." : "not equal.");
            Console.ReadKey();

            // String interning. Are these really two distinct objects?
            string a = "The computer ate my source code.";
            string b = "The computer ate my source code.";

            // ReferenceEquals returns true if both objects
            // point to the same location in memory.
            if (String.ReferenceEquals(a,b)) {
                Console.WriteLine("a and b are interned.");
            }
            else {
                Console.WriteLine("a and b are not interned.");
            }
            Console.ReadKey();

            // Use String.Copy method to avoid interning.
            string c = string.Copy(a);
            if (String.ReferenceEquals(a, c))
            {
                Console.WriteLine("a and c are interned.");
            }
            else
            {
                Console.WriteLine("a and c are not interned.");
            }
            Console.ReadKey();

        }
    }
}
