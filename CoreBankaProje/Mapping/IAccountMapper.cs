using CoreBankaProje.Data.Entities;
using CoreBankaProje.Models;

namespace CoreBankaProje.Mapping
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
