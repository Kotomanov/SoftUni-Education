using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputJson = File.ReadAllText(@"C:\Users\Lady Gaba\source\repos\EntityFrameworkCore\JSONProcessing\ProductShop\ProductShop\Datasets\categories-products.json");


            using (var db = new ProductShopContext())
            {
                //db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();

                var result = GetSoldProducts(db);

                Console.WriteLine(result);
            }

        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {

            var deserializedJson = JsonConvert.DeserializeObject<User[]>(inputJson);

            context.Users.AddRange(deserializedJson);

            context.SaveChanges();

            return $"Successfully imported {deserializedJson.Length}";


        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var deserializedJson = JsonConvert.DeserializeObject<Product[]>(inputJson);

            context.Products.AddRange(deserializedJson);

            context.SaveChanges();

            return $"Successfully imported {deserializedJson.Length}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var deserializedJson = JsonConvert.DeserializeObject<Category[]>(inputJson);

            foreach (var categorie in deserializedJson)
            {
                if (categorie.Name != null)
                {
                    context.Categories.AddRange(categorie);
                }

            }

            context.SaveChanges();

            return $"Successfully imported {context.Categories.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var deserializedJson = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);

            context.CategoryProducts.AddRange(deserializedJson);

            context.SaveChanges();

            return $"Successfully imported {deserializedJson.Length}";
        }


        public static string GetProductsInRange(ProductShopContext context)
        {

            var productsInRange = context.Products
                                         .Where(p => p.Price >= 500 && p.Price <= 1000)
                                         .OrderBy(p => p.Price)
                                         .Select(p => new
                                         {
                                             name = p.Name,
                                             price = p.Price,
                                             seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                                         })
                                         .ToList();

            var serializedJson = JsonConvert.SerializeObject(productsInRange, Formatting.Indented);

            return serializedJson;
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                               .Where(u=>u.ProductsSold.Any(ps=>ps.Buyer != null))
                               .OrderBy(u => u.LastName)
                               .ThenBy(u => u.FirstName)
                               .Select(u => new
                               {
                                   firstName = u.FirstName,
                                   lastName = u.LastName,
                                   soldProducts = u.ProductsSold
                                                  .Where(pb => pb.Buyer != null)
                                                  .Select(p => new
                                                  {
                                                      name = p.Name,
                                                      price = p.Price,
                                                      buyerFirstName = p.Buyer.FirstName,
                                                      buyerLastName = p.Buyer.LastName
                                                  })
                                                  .ToList()
                               })
                               .ToList();

            var jsonProduct = JsonConvert.SerializeObject(users, Formatting.Indented);

            return jsonProduct;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {


            var categories = context.Categories
                                    .Select(c => new
                                    {
                                        category = c.Name,
                                        productsCount = c.CategoryProducts.Count,
                                        averagePrice = $"{c.CategoryProducts.Sum(cp => cp.Product.Price) / c.CategoryProducts.Count:f2}",
                                        totalRevenue = $"{c.CategoryProducts.Sum(cp => cp.Product.Price):f2}"
                                    })
                                    .OrderByDescending(c => c.productsCount)
                                    .ToList();




            var jsonProduct = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return jsonProduct;
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                               .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                                                              .Select(u => new
                                                              {
                                                                  firstName = u.FirstName,
                                                                  lastName = u.LastName,
                                                                  age = u.Age,
                                                                  soldProducts = new
                                                                  {
                                                                      count = u.ProductsSold
                                                                                .Where(p => p.Buyer != null)
                                                                                .Count(),
                                                                      products = u.ProductsSold
                                                                     .Where(p => p.Buyer != null)
                                                                     .Select(ps => new
                                                                     {
                                                                         name = ps.Name,
                                                                         price = ps.Price
                                                                     })
                                                                     .ToList()
                                                                  }
                                                              })
                                                              .OrderByDescending(u => u.soldProducts.count)
                                                              .ToList();

            var usersOutput = new
            {
                usersCount = users.Count(),
                users = users
            };

            var jsonUsers = JsonConvert.SerializeObject
                (usersOutput, new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Ignore
                }
                );



            return jsonUsers;
        }



    }
}