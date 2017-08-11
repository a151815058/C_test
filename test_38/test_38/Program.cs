using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//參考相等意指兩個物件參考全都參考到同一個基礎物件
namespace test_38
{
    class Program
    {
        public int Num { get; set; }
        public string Str { get; set; }
        static void Main(string[] args)
        {
            Program a = new Program { Num =1, Str ="Hi" };
            Program b = new Program { Num =1, Str ="Hi" };

            bool areEqual = System.Object.ReferenceEquals(a,b);

            Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);

            b = a; //Assign  b to a

            areEqual = System.Object.ReferenceEquals(a, b);
            Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);

            Console.ReadKey();
        }
    }
}
