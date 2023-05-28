using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BrandService
{
    public interface IBrandService
    {

        IEnumerable<Brand> GetAllBrands();

        Brand GetBrandById(Guid id);

        void InsertBrand(Brand brand);

        void UpdateBrand(Brand brand);

        void DeleteBrand(Guid id);

 
    }
}
