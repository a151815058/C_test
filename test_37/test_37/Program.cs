using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//如何使用運算子多載化來建立一個定義複數加法的複數類別 Complex。 這個程式會顯示數值的虛數和實數部分，以及使用 ToString 方法之覆寫的加法運算結果
namespace test_37
{
    class Complex
    {
        public int imaginary;
        public int real;
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }
        public override string ToString()
        {
            return (System.String.Format("{0} + {1}i", real, imaginary));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex num1 = new Complex(2,3);
            Complex num2 = new Complex(3,4);

            Complex sum = num1 + num2;

            System.Console.WriteLine("First complex number:  {0}", num1);
            System.Console.WriteLine("Second complex number: {0}", num2);
            System.Console.WriteLine("The sum of the two numbers: {0}", sum);

            Console.ReadKey();
        }
    }
}
