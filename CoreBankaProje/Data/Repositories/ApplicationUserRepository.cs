using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.Entities;
using CoreBankaProje.Data.İnterfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoreBankaProje.Data.Repositories
{
  
    public class ApplicationUserRepository: IApplicationUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers.ToList();
        }

        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }
    }
}
