using APIPractice.Data;
using APIPractice.Data.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBaseRepository
    {

        private readonly AppDbContext _appDbContext;
        private DbSet<T> entities;


        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            entities = _appDbContext.Set<T>();
        }
        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Remove(entity);
           _appDbContext.SaveChanges();

        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            return entities.SingleOrDefault( x => x.Id.Equals(id));
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Add(entity);
            _appDbContext.SaveChanges();

        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Remove(entity);
           

        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        public void Update(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");

            }
            entities.Update(entity);
            _appDbContext.SaveChanges();

        }
    }
}
