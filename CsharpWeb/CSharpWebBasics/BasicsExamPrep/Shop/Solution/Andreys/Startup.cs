namespace Andreys.App
{
    using System.Collections.Generic;

    using Data;

    using SIS.MvcFramework;
    using SIS.HTTP;
    using Andreys.Services.Users;
    using Andreys.Services.Products;

    public class Startup : IMvcApplication
    {
        public void Configure(IList<Route> serverRoutingTable)
        {
            using (var db = new AndreysDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {

            //TODO initiate the services 
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<IProductsService, ProductsService>();
        }
    }
}
