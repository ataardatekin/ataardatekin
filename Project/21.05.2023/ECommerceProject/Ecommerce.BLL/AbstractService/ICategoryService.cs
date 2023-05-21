using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.AbstractService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();

        string CreateCategory(Category category);

        string DeleteCategory(Category category);

        Category FindCategory(int id);

        string UpdateCategory(Category category);

    }

}
