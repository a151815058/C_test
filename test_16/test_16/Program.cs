using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_16
{
    class Program
    {
        static void Main(string[] args)
        {

            //字串物件的不變性，s1會因為運算符號，而把s1原本的物件進行記憶體回收，並指派新的物件給s1
            string s1 = "This is a bird";
            string s2 = ", it can fly in the sky";

            s1 += s2;

            Console.WriteLine(s1);
            Console.ReadKey();

            //當s4是由s3傳參考給他時，當s3的值做異動時，s4並不會跟著異動，而是保留之前的字串
            string s3 = "Hello";
            string s4 = s3;

            s3 += "World";

            Console.WriteLine(s4);
            Console.ReadKey();

            //\t為鍵盤上的tab鍵，\r\n表示換行的意思
            string s5 = "My\tname\tis\t Wendy";
            Console.WriteLine(s5);
            string s6 = "My\r\n name\r\n is\r\n Wendy";
            Console.WriteLine(s6);
            Console.ReadKey();

            //當字串文字包含反斜線字元時 (例如檔案路徑)，請使用逐字字串(也就是加上@)，因為逐字字串會將新行字元保留為字串文字的一部分，因此可以將它們用來初始化多行字串。
            string s7 = @"C:\Users\scoleridge\Documents\";
            Console.WriteLine(s7);
            string s8 = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
            Console.WriteLine(s8);
            string s9 = @"Her name was ""Sara.""";
            Console.WriteLine(s9);
            Console.ReadKey();

            //格式字串
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            //轉換string為int，out表示傳參考
            int j;
            Int32.TryParse(input,out j);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} times {1} = {2}",i,j,i*j);
            }
            Console.ReadKey();


            //子字串
            string s10 = "Visual C# Express";
            Console.WriteLine(s10.Substring(7,2));

            Console.WriteLine(s10.Replace("C#", "Basic"));

            int index = s10.IndexOf("C");
            Console.WriteLine(index);
            Console.ReadKey();

            //存取個別字元
            string s11 = "Printing backwards";
            for (int i = 0; i < s11.Length; i++)
            {
                Console.Write(s11[s11.Length -i -1]);
            }
            Console.ReadKey();
        }
    }
}
