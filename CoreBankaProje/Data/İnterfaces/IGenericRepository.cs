using System.Collections.Generic;
using System.Security.Cryptography;

namespace CoreBankaProje.Data.İnterfaces
{
    public interface IGenericRepository<T> where T:class,new()
    {
        void Create(T entity);

        void Remove(T entity);

        List<T> GetAll();

        T GetById(object id);

        void Update(T entity);
    }
}
