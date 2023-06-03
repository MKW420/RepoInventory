using APIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductService
{
    public  interface IProductService
    {
        void DeleteProduct(Guid id);

        IEnumerable<Product> GetAllProducts();
 
        Product GetProductById(Guid id);

        void InsertProduct(Product product);    

        void UpdateProduct(Product product);

        int GetProductCount();
    }
}
