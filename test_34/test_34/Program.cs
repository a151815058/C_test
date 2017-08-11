using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//匿名方法
namespace test_34
{
    delegate void Printer(string s);
    class Program
    {
        static void Main(string[] args)
        {

            //只用"匿名方法"產生一個執行緒
            System.Threading.Thread t = new System.Threading.Thread(
                delegate() {
                    Console.Write("Hello, ");
                    Console.WriteLine("World!!");
                }
                );
            t.Start();

            //該委派被叫用 (Invoke) 時都會顯示訊息

            // Instantiate the delegate type using an anonymous method.
            Printer p = delegate (string j) {
                Console.WriteLine(j);
            };
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method "DoWork".
            p = new Printer(Program.DoWork);
            p("The delegate using the named method is called.");
            Console.ReadKey();

        }
        static void DoWork(string k) {
            System.Console.WriteLine(k);
        }
    }
}
