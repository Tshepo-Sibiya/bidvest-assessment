using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04_Debugging
{
    class Program
    {
        static readonly Speed s = new Speed();

        static void Main(string[] args)
        {
            Console.Write("KM: ");
            string hours = Console.ReadLine();
            Console.Write("Hours: ");
            string km = Console.ReadLine();

            double.TryParse(km, out s.km);
            double.TryParse(hours, out s.hours);

            Console.WriteLine("KPH: " + s.kph);
            Console.ReadKey();
        }
    }

    class Speed
    {
        public double km = 0;
        public double hours = 0;
        public int kph
        {
            get
            {
                return (int)(km / hours);
            }
        }
    }

}