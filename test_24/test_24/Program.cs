using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//下列範例會使用 IndexOf、LastIndexOf、StartsWith 和 EndsWith 方法來搜尋字串
namespace test_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Extension methods have all the capabilities of regular static methods.";
            //字串加上引號Write the string and include the quotation marks.
            Console.WriteLine("\"{0}\"", str);

            //Simple comparisons are always case sensitive!判斷開頭是否為extension?
            bool test1 = str.StartsWith("extension");
            Console.WriteLine("Starts with \"extension\"? {0}", test1);

            // For user input and strings that will be displayed to the end user, 
            // use the StringComparison parameter on methods that have it to specify how to match strings.
            bool test2 = str.StartsWith("extension",StringComparison.CurrentCultureIgnoreCase);//StringComparison.CurrentCultureIgnoreCase表示不理會字母的大小寫
            Console.WriteLine("Starts with \"extension\"? {0}", test2);

            bool test3 = str.EndsWith(".",StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("Starts with \"extension\"? {0}", test3);

            // This search returns the substring between two strings, so 
            // the first index is moved to the character just after the first string.
            int first = str.IndexOf("methods") + "methods".Length;
            int last = str.LastIndexOf("methods");
            string str2 = str.Substring(first, last - first);
            Console.WriteLine("first is {0},last is {1}", first, last);
            Console.WriteLine("Substring between \"methods\" and \"methods\": '{0}'", str2);


            Console.ReadKey();
        }
    }
}
