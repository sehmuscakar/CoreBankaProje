using CoreBankaProje.Data.Entities;
using CoreBankaProje.Models;

namespace CoreBankaProje.Mapping
{
    public class AccountMapper:IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber=model.AccountNumber,
                ApplicationUserId=model.ApplicationUserId,
                Balance=model.Balance,
            };
        }
    }
}
