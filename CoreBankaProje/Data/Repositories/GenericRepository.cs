using CoreBankaProje.Data.Context;
using CoreBankaProje.Data.İnterfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreBankaProje.Data.Repositories
{
    public class GenericRepository<T> :IGenericRepository<T> where T:class,new()
    {
        private readonly BankContext _context;

        public GenericRepository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            // DbSet<Account> bu _context.Set<T> buna karşılık geliyor yani 
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
    
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
           
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
