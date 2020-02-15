namespace IRunes.App
{
    using System.Collections.Generic;
    using IRunes.App.Services;
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
             
            }
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            //TODO 
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<ITracksService, TracksService>();
            serviceCollection.Add<IAlbumService, AlbumService>();
        }
    }
}
