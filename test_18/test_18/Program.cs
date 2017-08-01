using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//修改字串內容(取代＆移除字串)
namespace test_18
{
    class Program
    {
        string searchFor;
        string replaceWith;
        static void Main(string[] args)
        {
            Program app = new Program();
            string s = "The mountains are behind the clouds today.";

            //mountains取代為peaks
            s = s.Replace("mountains", "peaks");
            Console.WriteLine(s);
            Console.ReadKey();

            // Use Regex.Replace for more flexibility. 
            // Replace "the" or "The" with "many" or "Many".
            // using System.Text.RegularExpressions
            app.searchFor = "the";
            app.replaceWith = "many";
            s = Regex.Replace(s, app.searchFor, app.ReplaceMatchCase, RegexOptions.IgnoreCase);
            Console.WriteLine(s);

            s = s.Replace(" ","_");
            Console.WriteLine(s);
            Console.ReadKey();

            // Remove a substring from the middle of the string.
            string temp = "many_";
            int i = s.IndexOf(temp);
            if (i >= 0) {
                s.Remove(i, temp.Length);
            }
            Console.WriteLine(s);
            Console.ReadKey();

            // Remove trailing and leading whitespace.
            // See also the TrimStart and TrimEnd methods.
            string s2 = "    I'm wider than I need to be.      ";
            // Store the results in a new string variable.
            temp = s2.Trim();
            Console.WriteLine(temp);
            Console.ReadKey();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        string ReplaceMatchCase(Match m) {
            // Test whether the match is capitalized
            if (char.IsUpper(m.Value[0]) == true) {
                // Capitalize the replacement string
                // using System.Text;
                StringBuilder sb = new StringBuilder(replaceWith);
                sb[0] = char.ToUpper(sb[0]);
                return sb.ToString();
            }
            else {
                return replaceWith;
            }
        }
    }
}
