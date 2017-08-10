using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//範例示範如何透過 Enumerable.Where 標準查詢運算子
namespace test_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);




            //LINQ 查询範例
            string[] s = { "Hello", "wonderful", "LINQ", "beautiful", "World" };
            var shortWord = from word in s where s.Length >= 5 select word;
            foreach (string n in shortWord) {
                Console.WriteLine(n+"  ");
            }


            List<string> word1 =new List <string>(){"an", "apple", "a", "day" };
            var query = from s1 in word1 select s1.Substring(0, 1);
            foreach (string aa in query) {
                Console.WriteLine(aa + "  ");
            }

            List<string> word2 = new List<string>() { "an apple a day", "the quick brown fox" };
            var query1 = from s2 in word2
                         from s3 in s2.Split(' ')
                         select s3;
            foreach (string bb in query1) {
                Console.WriteLine(bb + "  ");
            }

            int[] num = { -20, 12, 6, 10, 0, -3, 1 };
            var posNums = from num1 in num
                          orderby num1
                          select num1;
            foreach (int n in posNums) {
                Console.Write(n+" \n");
                var posNumsDesc = from n1 in posNums
                                  orderby n1 descending
                                  select n1;
                Console.WriteLine("\nValues in descending order: ");

                foreach (int nn in posNumsDesc) {
                    Console.Write(nn + " \n");
                }
            }

            List<int> numbers = new List<int> { 35, 44, 200, 84, 3987, 4, 199, 329, 446, 208 };
            IEnumerable<IGrouping<int, int>> query2 = from number in numbers group number by number % 2;
            foreach (var group  in query2) {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");
                foreach (int i in group)
                    Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
