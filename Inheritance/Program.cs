using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualAccount individualAccount = new IndividualAccount();
            individualAccount.printDetails("T", "S", "90045202...");

            CorporateAccount corporateAccount = new CorporateAccount();
            corporateAccount.printDetails("Bidvest", "BV-77441122558");

            Console.ReadKey();
        }
    }

    abstract class Account
    {

        public string clientNumber;
        public string accountNumber;
        public string balance;

        public virtual void printDetails(string a, string b)
        {
            Console.WriteLine("Client no: " + clientNumber);
        }

        public virtual void printDetails(string a, string b, string c)
        {
            Console.WriteLine("Client no: " + clientNumber);
        }

    }

    class IndividualAccount : Account
    {
        public string firstName;
        public string surname;
        public string iDNumber;

        public override void printDetails(string firstName, string surname, string iDNumber)
        {
            Console.WriteLine("First Name: " + firstName + " | Surname: " + surname + " | ID No: " + iDNumber);
        }


    }

    class CorporateAccount : Account
    {
        public string companyName;
        public string companyRegNo;

        public override void printDetails(string companyName, string companyRegNo)
        {
            Console.WriteLine("Company Name: " + companyName + " | Company Reg: " + companyRegNo);
        }
    }


}
