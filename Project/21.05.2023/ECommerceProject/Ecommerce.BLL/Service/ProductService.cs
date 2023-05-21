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
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public string CreateProduct(Product product)
        {
            try
            {
                _productRepository.Create(product);
                return "Veri Eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteProduct(Product product)
        {
            try
            {
                product.Status = ECommerce.Entity.Enum.Status.Deleted;

                return _productRepository.Update(product);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Product FindProduct(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public string UpdateProduct(Product product)
        {
            try
            {
                product.Status = ECommerce.Entity.Enum.Status.Updated;
                return _productRepository.Update(product);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }



    }
}
