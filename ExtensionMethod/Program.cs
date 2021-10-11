using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Extensions.AddText("I understand"));
            Console.ReadKey();
        }
    }

    public static partial class Extensions
    {
        public static string AddText(string value)
        {
            return string.Format("{0} Extension Methods", value);
        }
    }
}
