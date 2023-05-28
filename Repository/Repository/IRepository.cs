
using APIPractice.Models;
using DomainLayer.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
      //  void DeleteById(Guid id);
        void SaveChanges();
       // void Delete(Guid id);
       // Brand Get(Guid id);
    }
}
