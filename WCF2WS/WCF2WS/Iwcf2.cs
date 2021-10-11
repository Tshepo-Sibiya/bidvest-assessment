using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF2WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iwcf2" in both code and config file together.
    [ServiceContract]
    public interface Iwcf2
    {
        [OperationContract]
        List<string> GetClientNumbers();
        [OperationContract]
        Customer GetCustomerDetails(string ClientNumber);

    }
}
