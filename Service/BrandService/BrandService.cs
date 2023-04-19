using APIPractice.Models;
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

        public void DeleteBrand(Brand brand)
        {
            _repository.Delete(brand);
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _repository.GetAll();
        }

        public Brand GetBrandById(int id)
        {
           return _repository.Get(id);
        }

        public void InserBrand(Brand brand)
        {
            _repository.Insert(brand);
        }

        public void UpdateBrand(Brand brand)
        {
            _repository.Update(brand);
        }
    }
}
