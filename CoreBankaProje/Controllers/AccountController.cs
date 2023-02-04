using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.Entities;
using CoreBankaProje.Data.İnterfaces;
using CoreBankaProje.Data.Repositories;
using CoreBankaProje.Mapping;
using CoreBankaProje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBankaProje.Controllers
{
    public class AccountController : Controller
    {

       

        private readonly IGenericRepository<Account> _accountRepository;
        private readonly IGenericRepository<ApplicationUser> _userRepository;

        public AccountController(IGenericRepository<Account> accountRepository, IGenericRepository<ApplicationUser> userRepository)
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
        }

        public IActionResult Create(int id)// oluşturacahın kişinın id si yani bu dışarıdan gelen 
        {



            var userInfo = _userRepository.GetById(id);
            return View(new UserLİstModel // biz burda view tarafında bu modeli dödürdük gibi düşün ve bu paremteleri orada da tanımladık otomatikme 
            {
                Id=userInfo.Id,
                Name=userInfo.Name,
                Surname=userInfo.Surname
            });
         
        }
        [HttpPost]
        public IActionResult Create(AccountCreateModel model) // burda accountcreatemodel ini paremetre olarak aldık ki aşahıda modeli kullanabilelim ,AccountCreateModel burdaki propertiyleri controllerda atama yapıpı o atamalrı viewde alabilmek için 
        {
            _accountRepository.Create(new Account
                {
                AccountNumber=model.AccountNumber,
                Balance=model.Balance,
                ApplicationUserId=model.ApplicationUserId
            });
          
            return RedirectToAction("Index", "Home");
        }
    }
}
