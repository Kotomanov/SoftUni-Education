namespace IRunes.App
{
    using System.Collections.Generic;

    using IRunes.Data;
    using Microsoft.EntityFrameworkCore;
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class Startup : IMvcApplication
    {
        public void Configure(IList<Route> serverRoutingTable)
        {
            using (var db = new RunesDbContext())
            {
                db.Database.EnsureCreated();
                //db.Database.Migrate(); 
            }
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
        }
    }
}
