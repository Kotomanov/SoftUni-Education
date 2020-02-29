namespace Andreys.App.Controllers
{
    using Andreys.Services.Products;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        private readonly IProductsService productsService;

        public HomeController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
        [HttpGet("/")]
        public HttpResponse IndexSlash  ()
        { 
            return this.Index();
        }

        public HttpResponse Index()
        {
            if (this.IsUserLoggedIn())
            {
                var allItems = productsService.ListAllProducts();
                return this.View(allItems, "Home");
            }
            return this.View();
        }
    }
}
