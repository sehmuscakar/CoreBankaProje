using CoreBankaProje.Data.Entities;
using CoreBankaProje.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreBankaProje.Mapping
{
    public class UserMapping:IUserMapper
    {
      

        public List<UserLİstModel> MapTolistOfUserList(List<ApplicationUser> users)
        {
            return users.Select(x => new UserLİstModel
            {
                Id = x.Id,
                Name=x.Name,
                Surname=x.Surname
            }).ToList();
        }

        public UserLİstModel MapToUserList(ApplicationUser user)
        {
            return new UserLİstModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname
            };
        }

    }
}
