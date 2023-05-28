using APIPractice.Models;
using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private IRepository<Category> _repository;

        public  CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public void DeleteCategory(Guid id)
        {
            try
            {
                if (id != null)
                {
                    Category category= GetCategoryById(id);
                    _repository.Remove(category);
                    _repository.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;

            }

        }
        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        public IEnumerable<Category> GetAllCategories()
        {

            try
            {
                var obj = _repository.GetAll();

                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;

            }

        }

        public Category GetCategoryById(Guid id)
        {
            try
            {
                var obj = _repository.Get(id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void InsertCategory(Category category)
        {
            _repository.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                if (category != null)
                {

                    _repository.Update(category);
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
