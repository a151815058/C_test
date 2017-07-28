using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using IEnumerator and IEnumerable
namespace test_11
{
    class Program
    {
        public class Person
        {
            public string first_name;
            public string last_name;
            public Person(string first_name, string last_name)
            {
                this.first_name = first_name;
                this.last_name = last_name;
            }
        }

        public class People : IEnumerable
        {
            public Person[] _people;
            public People(Person[] pArray) {
                _people = new Person[pArray.Length];
                for (int i = 0; i < pArray.Length; i++)
                {
                    _people[i] = pArray[i];
                }
            }


            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public PeopleEnum GetEnumerator()
            {
                return new PeopleEnum(_people);
            }
        }
        public class PeopleEnum : IEnumerator
        {
            public Person[] _people;
            int position = -1;
            public PeopleEnum(Person[] list) {
                _people = list;
            }

            public bool MoveNext()
            {
                position++ ;
                return (position < _people.Length);
            }
            public void Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }     
            }
            public Person Current {
                get
                {
                    try
                    {
                        return _people[position];
                    }
                    catch (IndexOutOfRangeException)
                    {

                        throw new InvalidOperationException();
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            Person[] p = new Person[3] {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(p);
            foreach (Person p1 in peopleList)
                Console.WriteLine(p1.first_name + " " + p1.last_name);

            Console.ReadKey();
        }
    }
}
