using Andreys.Services.Products;
using Andreys.ViewModels.Products;
using SIS.HTTP;
using SIS.MvcFramework;

namespace Andreys.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService service;

        public ProductsController(IProductsService service)
        {
            this.service = service;
        }
        public HttpResponse Add()
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }
            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(ProductInputModel product)
        {

            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (string.IsNullOrWhiteSpace(product.Name) ||
                string.IsNullOrWhiteSpace(product.Description) ||
                string.IsNullOrWhiteSpace(product.Gender) ||
                string.IsNullOrWhiteSpace(product.Category) ||
                string.IsNullOrWhiteSpace(product.ImageUrl) ||
                 product.Price < 0 ||
                 product.Name.Length > 20 ||
                 product.Name.Length < 4 ||
                 product.Description.Length > 10 ||
                 product.Category != "Shirt"
                 && product.Category != "Denim"
                 && product.Category != "Shorts" &&
                 product.Category != "Jacket" ||
                 product.Gender != "Male" && product.Gender != "Female"
                )
            {
                return this.Redirect("/Products/Add");
            }

            service.AddProduct(product.Name, product.Description, product.ImageUrl, product.Category, product.Gender, product.Price);
            //After deleting or creating a Product, redirect to the Home Page.
            return this.Redirect("/");

        }

        public HttpResponse Details(int id)
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var product = this.service.ProductDetails(id);
            return this.View(product);

        }

        public HttpResponse Delete(int id) //? //  After deleting or creating a Product, redirect to the Home Page
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (this.service.ProductDetails(id) != null)
            {
                //After deleting or creating a Product, redirect to the Home Page
                service.DeleteProduct(id);
                return this.Redirect("/");

            }

            return this.Redirect("/");

        }

    }
}
