using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//下列程式碼範例示範如何使用 String.Split 方法剖析字串
namespace test_23
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = {' ', ',', '.', ':', '\t' };

            string text = "one\ttwo three:four,five six seven";
            string[] words = text.Split(delimiterChars);
            Console.WriteLine("{0} words in text", words.Length);
            foreach (string s in words) {
                Console.WriteLine(s);
            }
            System.Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
