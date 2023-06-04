using APIPractice.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductService
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _repository;

        public Product _product;


        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
          
        }





        public void DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            

            try
            {
                var obj = _repository.GetAll().ToList();

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

        public Product GetProductById(Guid id)
        {
            try
            {
                var obj = _repository.Get(id);
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


        public int GetProductCount()
        {
            try
            {
                //grab the product qaunity
                int count = _repository.GetAll().Count();

                if(count > 0)
                {
                   return count;
                }
                else
                {
                    //convert null into int
                    return Int32.Parse(null);
                   
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void InsertProduct(Product product)
        {
            _repository.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                if (product != null)
                {

                    _repository.Update(product);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
