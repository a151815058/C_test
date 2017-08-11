using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_42
{
    class TimePeriod {
        private double seconds;

        public double Hours {
            get { return seconds / 3600; }
            set {
                if (value <0 || value >24) {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 24.");
                }
                seconds = value * 3600;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();

            t.Hours = 24;

            Console.WriteLine($"Time in hours: {t.Hours}");

            Console.ReadKey();
        }
    }
}
