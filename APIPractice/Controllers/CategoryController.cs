using APIPractice.Models;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.BrandService;
using ServiceLayer.CategoryService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
   
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> GetAllCategories()
        {

            foreach (var category in _categoryService.GetAllCategories())
            {
                yield return category;
            }




        }

        // POST api/<BrandsController>
        [HttpPost]
        public IActionResult InsertCategory(Category category)
        {
            _categoryService.InsertCategory(category);
            return Ok("Data succesfully inserted");


        }

        // PUT api/<BrandsController>/5
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {

            _categoryService.UpdateCategory(category);
            return Ok("Updating done");
        }
    }
}
