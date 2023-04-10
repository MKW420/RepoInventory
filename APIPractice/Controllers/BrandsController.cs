using APIPractice.Data;
using APIPractice.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //var _Db;
        private AppDbContext _context;
        public BrandsController( AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<BrandsController>
        [HttpGet("{GetAllBrands}")]
        public IEnumerable<Brand> Get()
        {
            var brands = _context.brands.ToList();

            foreach (var brand in brands)
            {
                yield return brand;
            }
            
            
           // return new string[] { "value1", "value2" };
        }

        // GET api/<BrandsController>/5
        [HttpGet("{GetBrandById}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BrandsController>
        [HttpPost("{InsertBrand}")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BrandsController>/5
        [HttpPut("{UpdateBrandById}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
