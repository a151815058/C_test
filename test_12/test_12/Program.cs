using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//認識C#陣列
namespace test_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoresQuery = from score in scores where score > 80 select score;

            // Execute the query.
            foreach (int i in scoresQuery) {
                Console.WriteLine(i + "  ");
            }

            Console.ReadKey();
        }
    }
}
