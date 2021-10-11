using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01_ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write("Error info: " + ex.Message);
            }
  
        }
    }
}
