using Andreys.Models;
using Andreys.ViewModels.Products;
using System.Collections.Generic;

namespace Andreys.Services.Products
{
    public interface IProductsService
    {
        int AddProduct(string name,string description, string url, string category, string gender, decimal price);

        IEnumerable<Product> ListAllProducts();

        Product ProductDetails(int id); 

        void DeleteProduct(int id); //??

    }
}
