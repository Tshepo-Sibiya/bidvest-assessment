using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Q07_1_WCF1
{
    public class AccountService : IAccountService
    {
        public List<AccountType> GetAccountTypes()
        {
            List<AccountType> l = new List<AccountType>();
            l.Add(new AccountType() { ID = 1, Name = "Current" });
            l.Add(new AccountType() { ID = 2, Name = "Savings" });
            l.Add(new AccountType() { ID = 3, Name = "Bond" });
            return l;
        }

    }
}
