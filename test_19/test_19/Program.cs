using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//取代個別字元
namespace test_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumped over the fence";
            Console.WriteLine(str);
            Console.ReadKey();
            char[] chars = str.ToCharArray();
            int animalIndex = str.IndexOf("fox");
            Console.WriteLine(animalIndex);
            if (animalIndex != -1) {
                chars[animalIndex++] = 'c';
                chars[animalIndex++] = 'a';
                chars[animalIndex] = 't';
            }

            string str2 = new string(chars);
            Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
