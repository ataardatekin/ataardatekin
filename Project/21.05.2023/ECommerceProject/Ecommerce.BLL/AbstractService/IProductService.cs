using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BLL.AbstractService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();

        string CreateProduct(Product product);

        string DeleteProduct(Product product);

        Product FindProduct(int id);

        string UpdateProduct(Product product);


    }
}
