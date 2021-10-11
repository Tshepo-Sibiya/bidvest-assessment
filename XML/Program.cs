using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateData();
        }

        // This function must list all the Character NAMES and their AGE
        // Use the "sample.xml" file in this project to get the information
        // Final Result must be 4 Rows/lines     
        // Example Row Format:       Name (Age)
        private static void PopulateData()
        {
            // LOAD XML INTO STRING 
            var xml = new StreamReader("sample.xml").ReadToEnd();

            // DIPLAY EACH ROW IN THE CONSOLE APP - add code here


            // AND UR DONE
            Console.ReadKey();
        }

    }
}