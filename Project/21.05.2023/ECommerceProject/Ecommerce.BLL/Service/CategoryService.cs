using Ecommerce.BLL.Abstract;
using Ecommerce.BLL.AbstractService;
using ECommerce.Entity.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> repository)
        {
            _categoryRepository = repository;
        }

        public string CreateCategory(Category category)
        {
            try
            {
                _categoryRepository.Create(category);
                return "Veri oluşturuldu!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteCategory(Category category)
        {
            try
            {
                category.Status = ECommerce.Entity.Enum.Status.Deleted;
                
                return _categoryRepository.Update(category);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Category FindCategory(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll().ToList();
        }

        public string UpdateCategory(Category category)
        {
            try
            {
                category.Status = ECommerce.Entity.Enum.Status.Updated;
                return _categoryRepository.Update(category);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
