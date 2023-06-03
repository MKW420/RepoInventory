using APIPractice.Models;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProductService;

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

     private readonly IProductService _productService;


        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpGet(nameof(GetAllProducts))]
        public IEnumerable<Product> GetAllProducts()
        {

            foreach (var product in _productService.GetAllProducts())
            {
                yield return product;
            }

        }

        //// GET: api/< ProductsController>
        [HttpGet(nameof(GetProductByID))]
        public IActionResult GetProductByID(Guid id)
        {
            var product = _productService.GetProductById(id);

            if (product is not null)
            {
                return Ok(product);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetProductCount))]
        public IActionResult GetProductCount()
        {
            int count = _productService.GetProductCount();

            return Ok("Total number products is: " + count);

            //  return BadRequest("No records found!");
        }
        // POST api/<ProductController>
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(Product product)
        {


            _productService.InsertProduct(product);
            return Ok("Data successfully inserted");


        }
        // PUT api/<ProductController>/5
        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {

            _productService.UpdateProduct(product);
            return Ok("Updating done");
        }

        // DELETE api/<ProductController>/5
        [HttpDelete(nameof(DeleteProduct))]
        public IActionResult DeleteProduct(Guid id)
        {
            _productService.DeleteProduct(id);
            return Ok("Deleted Data!");

        }

      
    }
}
