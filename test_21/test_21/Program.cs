using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
//示範如何使用採用 StringComparison 列舉的 System.String 方法，以慣用方式比較字串
namespace test_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // "They dance in the street."
            // Linguistically (in Windows), "ss" is equal to 
            // the German essetz: 'ß' character in both en-US and de-DE cultures.

            string first = "Sie tanzen in die Straße.";
            string second = "Sie tanzen in die Strasse.";

            Console.WriteLine("first sentense is {0}", first);
            Console.WriteLine("second sentense is {0}", second);
            Console.ReadKey();

            // Store CultureInfo for the current culture. Note that the original culture
            // can be set and retrieved on the current thread object.
            Thread thread = Thread.CurrentThread;//取得目前的执行序
            CultureInfo originalCulture = thread.CurrentCulture;

            // Set the culture to en-US.
            thread.CurrentCulture = new CultureInfo("zh-TW");

            // For culture-sensitive comparisons, use the String.Compare 
            // overload that takes a StringComparison value.
            int i = String.Compare(first, second, StringComparison.CurrentCulture);
            Console.WriteLine("Comparing in {0} returns {1}.", originalCulture.Name, i);
            Console.ReadKey();

            // Set the culture to en-US.
            thread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            i = String.Compare(first, second,StringComparison.CurrentCulture);
            Console.WriteLine("Comparing in {0} returns {1}.", originalCulture.Name, i);
            Console.ReadKey();

            thread.CurrentCulture = originalCulture;
            bool b = String.Equals(first, second, StringComparison.CurrentCulture);
            Console.WriteLine("The two strings {0} equal.", b == true ? "are" : "are not");
            Console.ReadKey();


        }
    }
}
