using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//執行階段的類型轉換例外狀況
namespace test_6
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.");
            Console.ReadKey();
        }
        public override string ToString()
        {
            return "I am an animal.";
        }
    }
    class Reptile : Animal { }
    class Mammal : Animal { }
    class Program
    {
        static void Main(string[] args)
        {
            test(new Mammal());
        }

        static void test(Animal a)
        {
            // Cause InvalidCastException at run time 
            // because Mammal is not convertible to Reptile.
            Animal r = (Animal)a;
            r.Eat();
        }
    }
}
