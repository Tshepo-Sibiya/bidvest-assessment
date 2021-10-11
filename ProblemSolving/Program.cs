using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05_ProblemSolving
{
    class Program
    {
        public static void Main(string[] args)
        {
            var value1 = "38475634639";
            var value2 = "88475634639";

            Console.WriteLine("{0}: {1}", value1, IsValid(value1));
            Console.WriteLine("{0}: {1}", value2, IsValid(value2));
            Console.ReadLine();
        }

        public static bool IsValid(string value)
        {
            throw new NotImplementedException();
        }
    }
}
