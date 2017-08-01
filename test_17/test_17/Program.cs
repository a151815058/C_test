using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//串接多個字串
namespace test_17
{
    class Program
    {
        static void Main(string[] args)
        {


            string userName ="wendyyao";
            string Date = DateTime.Today.ToShortDateString();

            string str = "Hello "+userName+ ". Today is " + Date + ".";
            Console.WriteLine(str);

            str += "How are u today?";
            Console.WriteLine(str);
            Console.ReadKey();

            //當效能很重要時，一定要使用 StringBuilder 類別 (Class) 來串連字串
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
