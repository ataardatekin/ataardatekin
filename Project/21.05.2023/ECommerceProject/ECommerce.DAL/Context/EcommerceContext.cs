//Microsoft.AspNetCore.Identity.EntityFrameworkCore
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools

using ECommerce.DAL.Seed;
using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.DAL.Context
{
    public class EcommerceContext:IdentityDbContext
    {

        //Tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        //FakeData
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //category
            builder.Entity<Category>().HasData(CategorySeed.categories);

            //Product
            builder.Entity<Product>().HasData(ProductSeed.products);



            base.OnModelCreating(builder);
        }




        //ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = ATA\\SQLEXPRESS; Database = EcommerceDB; Trusted_Connection = True;");
            }
        }
    }
}
