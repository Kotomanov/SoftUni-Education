using Andreys.Data;
using Andreys.Models;
using Andreys.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Andreys.Services.Products
{
    public class ProductsService : IProductsService
    {
        private readonly AndreysDbContext db;
        public ProductsService(AndreysDbContext db)
        {
            this.db = db;
        }

        public int AddProduct(string name, string description, string url, string category, string gender, decimal price)
        {

            var categoryEnum = Enum.Parse<Category>(category);
            var genderEnum = Enum.Parse<Gender>(gender);


            var product = new Product
            {
                Name = name,
                Description = description,
                ImageUrl = url,
                Category = categoryEnum,
                Gender = genderEnum,
                Price = price,

            };

            this.db.Products.Add(product);
            this.db.SaveChanges();

            return product.Id;
        }

        public void DeleteProduct(int id)
        {
            var product = this.db.Products
                .Where(p => p.Id == id)
                .First();
            this.db.Products.Remove(product);
            this.db.SaveChanges();
        }

        public IEnumerable<GetAllProducts> ListAllProducts()
            => this.db.Products
            .Select(x =>
            new GetAllProducts
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
            }).ToList();

        public Product ProductDetails(int id)
       => this.db.Products.FirstOrDefault(p => p.Id == id); 
    }
}
