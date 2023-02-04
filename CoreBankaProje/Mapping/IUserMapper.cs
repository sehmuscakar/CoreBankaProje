using CoreBankaProje.Data.Entities;
using CoreBankaProje.Models;
using System.Collections.Generic;

namespace CoreBankaProje.Mapping
{
    public interface IUserMapper
    {
        List<UserLİstModel> MapTolistOfUserList(List<ApplicationUser> users);

        UserLİstModel MapToUserList(ApplicationUser user);
    }
}
