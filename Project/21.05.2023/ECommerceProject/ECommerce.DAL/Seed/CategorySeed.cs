using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Seed
{
    internal class CategorySeed
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category{Id=1,CategoryName="Giyim",Description="adsadfsfd"},
            new Category{Id=2,CategoryName="Teknoloji",Description="adsadfsfd"},
            new Category{Id=3,CategoryName="Yemek",Description="adsadfsfd"}
        };


    }
}
