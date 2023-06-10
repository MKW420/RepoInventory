using RepositoryLayer;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.BrandService;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {


        private readonly IBrandService _brandService;

   
        public BrandController(IBrandService brandService)
        {
           _brandService = brandService;
        }


    

        // GET api/<BrandsController>/5
        [HttpGet(nameof(GetAllBrands))]
        public IEnumerable<Brand> GetAllBrands()
        {
            
            foreach (var brand in _brandService.GetAllBrands())
            {
                yield return brand;
            }

        }

        //// GET: api/<BrandsController>
        [HttpGet(nameof(GetBrandByID))]
        public IActionResult GetBrandByID(Guid id)
        {
            var brand = _brandService.GetBrandById(id);

            if (brand is not null)
            {
                return Ok(brand);
            }
            return BadRequest("No records found");
        }

        // POST api/<BrandsController>
        [HttpPost(nameof(InsertBrand))]
        public IActionResult InsertBrand(Brand brand)
        { 

          
            _brandService.InsertBrand(brand);
            return Ok("Data successfully inserted");


        }

        // PUT api/<BrandsController>/5
        [HttpPut(nameof(UpdateBrand))]
        public IActionResult UpdateBrand(Brand brand)
        {

            _brandService.UpdateBrand(brand);
            return Ok("Updating done");
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete(nameof(DeleteBrand))]
        public IActionResult DeleteBrand(Guid id)
        {
            _brandService.DeleteBrand(id);
            return Ok("Deleted Data!");

        }

     //   public List<Brand> GetThis()
      //  {
      //     List<Brand> result = new List<Brand>();

      //      _brandService.GetAllBrands();

          //  var brandy = _brandService.GetAllBrands().Where(x => x.Brand_Name == "hello").Select(p => p.)
      //  }
      //  public IActionResult GetResult(string searchString) {


          //  return _brandService.GetBrandBySearch(searchString);
       // }
    }
}
