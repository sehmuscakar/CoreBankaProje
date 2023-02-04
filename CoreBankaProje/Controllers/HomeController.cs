using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.Entities;
using CoreBankaProje.Data.İnterfaces;
using CoreBankaProje.Data.Repositories;
using CoreBankaProje.Mapping;
using CoreBankaProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBankaProje.Controllers
{
    public class HomeController : Controller
    {
     //   private readonly BankContext _context;//burdaki _context burdaki controllerlarda tek geçerli,burda contsractır oluşturduk işte yapıcı fonksiyon
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        public HomeController(BankContext context, IApplicationUserRepository applicationUserRepository,IUserMapper userMapper)
        {

          //  _context = context;
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            //_context = context;
            //_applicationUserRepository = new ApplicationUserRepository(_context);//burda homecontroller, ApplicationUserRepository e bağımlı oldu bu bağımlığı azaltmak için Interface kullanacaz 
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapTolistOfUserList(_applicationUserRepository.GetAll()));//burda select kısmı birdefa yapıp diğer yerlerde de kullanmak için
            
            ////burda model kullanmamızaki sebep direk olarak applicationusers deki butun propertyleri almadan ihtiyacaımız olanı almak için model kısmına gitik 
            //return View(_context.ApplicationUsers.Select(x => new UserLİstModel
            //{
            //    Id = x.Id,// x.Id bunlar model de tanımladığımız propertyler ,Id bu ıd ye atadık bunuda viewde modeli tanımlatarak viewde cağıracaz
            //    Name =x.Name,
            //    Surname=x.Surname
            //}


            //    ).ToList()); ;//burdaki yapıcı fonksiyon sayesinde _context ile dbset teki lere ulaştık ve viewe gönderdik 
        }
    }
}
