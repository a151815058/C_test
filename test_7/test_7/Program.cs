using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//轉型和類型轉換
namespace test_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // String.Concat example.
            // String.Concat has many versions. Rest the mouse pointer on 
            // Concat in the following statement to verify that the version
            // that is used here takes three object arguments. Both 42 and
            // true must be boxed.
            //Console.WriteLine(String.Concat("Answer",42,true));


            // List example.
            // Create a list of objects to hold a heterogeneous collection 
            // of elements.
            List<object> mixedList = new List<object>();

            // Add a string element to the list. 
            mixedList.Add("First Group:");

            // Add some integers to the list. 
            for (int i = 1; i < 5; i++)
            {
                // Rest the mouse pointer over j to verify that you are adding
                // an int to a list of objects. Each element j is boxed when 
                // you add j to mixedList.
                mixedList.Add(i);
            }

            mixedList.Add("Second Group:");
            // Add another string and more integers.
            for (int i = 5; i < 10; i++)
            {
                mixedList.Add(i);
            }

            // Display the elements in the list. Declare the loop variable by 
            // using var, so that the compiler assigns its type.
            foreach (var item in mixedList)
            {
                // Rest the mouse pointer over item to verify that the elements
                // of mixedList are objects.
                Console.WriteLine(item);
            }

            var sum = 0;
            for (int i = 1; i < 5; i++)
            {
                // The following statement causes a compiler error: Operator 
                // '*' cannot be applied to operands of type 'object' and
                // 'object'. 
                //sum += mixedList[j] * mixedList[j]);

                // After the list elements are unboxed, the computation does 
                // not cause a compiler error.
                sum += (int)mixedList[i] * (int)mixedList[i];
            }
            // The sum displayed is 30, the sum of 1 + 4 + 9 + 16.
            Console.WriteLine("sum = {0}",sum);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
