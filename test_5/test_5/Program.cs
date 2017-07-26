using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//一次一行讀取文字檔
namespace test_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\test_for_C#\test_2.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("Total conut :{0}", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
