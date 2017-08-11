using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//結構是實值型別，所以結構物件的變數會保留完整物件的複本
namespace test_39
{
    public struct Person {
        public string Name;
        public int Age;
        public Person(string Name,int Age) {
            this.Name = Name;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alex", 9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name,p1.Age);

            Person p2 = p1;

            p2.Name = "Spencer";
            p2.Age = 7;

            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            Console.ReadKey();
        }
    }
}
