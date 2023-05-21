using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Seed
{
    internal class ProductSeed
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1,ProductName="Nike Airmax",Description="İyi ayakkabı",CategoryId=1,UnitPrice=5150,UnitsInStock=556},
            new Product { Id = 2,ProductName="Iphone 14",Description="güzel",CategoryId=2,UnitPrice=51500,UnitsInStock=20},
            new Product { Id = 3,ProductName="BigMac",Description="lezzetli",CategoryId=3,UnitPrice=51,UnitsInStock=5565}
        };
    }
}
