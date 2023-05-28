using APIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CategoryService
{
    public interface ICategoryService
    {

         void DeleteCategory(Guid id);

        IEnumerable<Category> GetAllCategories();

        Category GetCategoryById(Guid id);

        void InsertCategory(Category category);

        void UpdateCategory(Category category);
    }
}
