using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF2WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcf2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcf2.svc or wcf2.svc.cs at the Solution Explorer and start debugging.
    public class wcf2 : Iwcf2
    {
        private List<Customer> customers = new List<Customer>();

        public wcf2()
        {
            customers.Add(new Customer() { ClientNumber = "0001231", Name = "John Smith", IDNo = "8001215123012" });
            customers.Add(new Customer() { ClientNumber = "0001232", Name = "Andrew King", IDNo = "7303115019023" });
            customers.Add(new Customer() { ClientNumber = "0001233", Name = "David Williams", IDNo = "8710185765034" });
            customers.Add(new Customer() { ClientNumber = "0001234", Name = "Mary Jones", IDNo = "6511054321045" });
            customers.Add(new Customer() { ClientNumber = "0001235", Name = "Jane Adams", IDNo = "9902231122056" });
        }

        public List<string> GetClientNumbers()
        {
            return customers.Select(x => x.ClientNumber).ToList();
        }

        public Customer GetCustomerDetails(string ClientNumber)
        {
            return customers.FirstOrDefault(x => x.ClientNumber == ClientNumber);
        }

    }
}
