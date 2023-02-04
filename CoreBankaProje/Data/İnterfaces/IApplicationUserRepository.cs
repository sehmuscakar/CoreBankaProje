using CoreBankaProje.Data.Entities;
using System.Collections.Generic;

namespace CoreBankaProje.Data.İnterfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();

        ApplicationUser GetById(int id);
    }
}
