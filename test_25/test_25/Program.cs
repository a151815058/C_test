using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
//在陣列中執行不區分大小寫的簡單字串搜尋
namespace test_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = {"C# code","Chapter 2: Writing Code","Unicode","no match here" };

            string sPattern = "code";

            foreach (string s in sentences) {
                Console.Write("{0,24}",s);
                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)) {
                    Console.WriteLine("  (match for '{0}' found)", sPattern);
                }
                else {
                    System.Console.WriteLine();
                }
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
