using RepositoryLayer;
using APIPractice.Models;
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

        
        //var _Db;
        private AppDbContext _context;
        public BrandController(IBrandService brandService)
        {
           _brandService = brandService;
        }


        // GET: api/<BrandsController>
        [HttpGet("{GetBrandByID}")]
        public IActionResult GetBrands(Guid id)
        {
            var brands = _brandService.GetBrandById(id);

           if(brands is not null){
                 return Ok(brands);
            }
            return BadRequest("No records found");    
        }


        // GET api/<BrandsController>/5
        [HttpGet("{GetAllBrands}")]
        public IActionResult GetAllBrands()
        {
            var brands =  _brandService.GetAllBrands();
            if (brands is not null) { 
            
                return Ok(brands);
            
            }

            return BadRequest("No records found");
        }

        // POST api/<BrandsController>
        [HttpPost("{InsertBrand}")]
        public IActionResult InsertBrand(Brand brand)
        { 
            _brandService.InsertBrand(brand);
            return Ok("Data inserted");


        }

        // PUT api/<BrandsController>/5
        [HttpPut("{UpdateBrandById}")]
        public IActionResult UpdateBrand(Brand brand)
        {

            _brandService.UpdateBrand(brand);
            return Ok("Updating done");
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(Guid id)
        {
            _brandService.DeleteBrand(id);
            return Ok("Deleted Data!");

        }
    }
}
