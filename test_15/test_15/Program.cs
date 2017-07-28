using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//使用 ref 和 out 傳遞陣列  
//以 ref 參數傳遞的引數必須先被初始化，out 則不需要。
//out 參數要在離開目前的方法之前至少有一次指派值的動作。
//若兩個方法僅有 ref、out 關鍵字的差異，在編譯期會視為相同方法簽章，無法定義為多載方法。

namespace test_15
{
    class Program
    {

//use out
        static void FillArray(out int[] arr) {
            // Initialize the array:
            arr = new int[] { 1,2,3,4,5};
        }
        //use ref
        static void FillArray2(ref int[] arr) {
            if (arr == null) {
                arr = new int[10];
            }
            arr[0] = 111;
            arr[3] = 555;
        }
        static void Main(string[] args)
        {
            int[] theArray;// Initialization is not required

            // Pass the array to the callee using out:
            FillArray(out theArray);

            // Display the array elements:
            System.Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine(theArray[i]+" ");
            }


            // Initialize the array:
            int[] theArray2 = new int[] { 1,2,3,4,5};// Initialization is not 
            // Pass the array using ref:
            FillArray2(ref theArray2);

            // Display the updated array:
            System.Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray2.Length; i++)
            {
                System.Console.Write(theArray2[i] + " ");
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
