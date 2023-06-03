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
        [HttpGet(nameof(GetAllCategories))]
        public IEnumerable<Category> GetAllCategories()
        {

            foreach (var category in _categoryService.GetAllCategories())
            {
                yield return category;
            }

            

        }

        //// GET: api/<categoriesController>
        [HttpGet(nameof(GetByCategoryByID))]
        public IActionResult GetByCategoryByID(Guid id)
        {
            var category = _categoryService.GetCategoryById(id);

            if (category is not null)
            {
                return Ok(category);
            }
            return BadRequest("No records found");
        }


        // POST api/<CategoryController>
        [HttpPost(nameof(InsertCategory))]
        public IActionResult InsertCategory(Category category)
        {
            _categoryService.InsertCategory(category);
            return Ok("Data succesfully inserted");


        }

        // PUT api/<CategoryController>/5
        [HttpPut(nameof(UpdateCategory))]
        public IActionResult UpdateCategory(Category category)
        {

            _categoryService.UpdateCategory(category);
            return Ok("Updating done");
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete(nameof(DeleteCategory))]
        public IActionResult DeleteCategory(Guid id)
        {
            _categoryService.DeleteCategory(id);
            return Ok("Deleted Data!");

        }
    }
}
