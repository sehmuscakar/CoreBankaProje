using CoreBankaProje.Data.Configurations;
using CoreBankaProje.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBankaProje.Data.Context
{
    public class BankContext:DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        //biz burda  Dependency Injection a göre entity farmework te veritabanı bağlantımızı yapacaz 
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {
            //options ile base deki optionsa gidecek oradan da dbconext nesnesine gidecek 
            //tabi startab tarafında da dbcantext servisini ekle ve ilgili kodları yaz 
        
        }
        //burda da configrasyonları oluşturduk
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // burda yazdığımız configrasyonları dahil ediyoruz oluşturuyoruz yani
            modelBuilder.ApplyConfiguration(new ApplicationUserConfigration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}
