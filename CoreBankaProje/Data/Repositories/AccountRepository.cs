using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.Entities;
using CoreBankaProje.Data.İnterfaces;

namespace CoreBankaProje.Data.Repositories
{

    public class AccountRepository:IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }


        public void Create(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
       }

    }
}
