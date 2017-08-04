using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//如何使用採用 System.StringComparer 參數的靜態 Array 方法，在陣列中以區分文化特性的方式排序及搜尋字串
namespace test_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[] {
                @"c:\public\textfile.txt",
                @"c:\public\textFile.TXT",
                @"c:\public\Text.txt",
                @"c:\public\testfile2.txt"
            };

            Console.WriteLine("Non-sorted order:");
            foreach (string s in lines) {
                Console.WriteLine("   {0}",s);
            }
            Console.ReadKey();

            Console.WriteLine("\n\rSorted order:");
            Array.Sort(lines,StringComparer.Ordinal);
            foreach (string s in lines) {
                Console.WriteLine("   {0}",s);
            }
            Console.ReadKey();

            string searchString = @"c:\public\TEXTFILE.TXT";
            Console.WriteLine("Binary search for {0}",searchString);
            Console.ReadKey();

            int result = Array.BinarySearch(lines, searchString,StringComparer.OrdinalIgnoreCase);
            ShowWhere<string>(lines, result);

            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
        // Displays where the string was found, or, if not found,
        // where it would have been located.
        static void ShowWhere<T>(T[] array,int index) {
            if (index < 0) {
                // If the index is negative, it represents the bitwise
                // complement of the next larger element in the array.
                //「~」 運算子會在運算元上執行反轉每個位元的位元補數運算
                index = ~index;
                Console.Write("Not found. Sorts between: ");
                if (index == 0) {
                    Console.Write("beginning of array and ");
                }
                else {
                    Console.Write("{0} and",array[index -1]);
                }

                if (index == array.Length) {
                    Console.WriteLine("end of array.");
                }
                else {
                    Console.WriteLine("{0}.", array[index]);
                }
            }
            else {
                Console.WriteLine("Found at index {0}.", index);
            }
        }
    }
}
