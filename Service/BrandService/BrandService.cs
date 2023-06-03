using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BrandService
{
    public class BrandService: IBrandService
    {

        private IRepository<Brand> _repository;

        public BrandService(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public void DeleteBrand(Guid id)
        {
            try
            {
                if(id != null)
                {
                    Brand brand = GetBrandById(id);
                    _repository.Remove(brand);
                    _repository.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;

            }
          
        }
        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        public IEnumerable<Brand> GetAllBrands()
        {

            try
            {
                var obj =  _repository.GetAll();

                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;

            }
          
        }

        public Brand GetBrandById(Guid id)
        {
            try
            {
                 var obj =  _repository.Get(id);
                if(obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
         
        }

        public Brand GetBrandBySearch(string searchString)
        {
            throw new NotImplementedException();
        }

        public void InsertBrand(Brand brand)
        {
            _repository.Insert(brand);
        }

        public void UpdateBrand(Brand brand)
        {
            try
            {
                if(brand != null) {
                    
                        _repository.Update(brand);
                    } 
             
            }
            catch (Exception)
            {
                throw;
            }
           
        }


       // public Brand GetBrandBySearch(string searchString)
     //   {
      //      return _repository.Where(x => x.Equals(searchString)) ;
       // /}

    }
}
