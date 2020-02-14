using IRunes.App.Services;
using IRunes.App.ViewModels.Tracks;
using SIS.HTTP;
using SIS.MvcFramework;

namespace IRunes.App.Controllers
{
    public class TracksController : Controller
    {

        private readonly ITracksService service; 
        public TracksController(ITracksService service)
        {
            this.service = service; 
        }
        public HttpResponse Create(string albumId)
        {
            if (this.IsUserLoggedIn())
            {

                var viewModel = new CreateViewModel
                {
                    AlbumId = albumId

                };

                return this.View();
            }

            return this.Redirect("/Users/Login");
        }

        [HttpPost]
        public HttpResponse Create(CreateInputModel input)
        {
            if (this.IsUserLoggedIn())
            {
                if (input.Name.Length < 4 || input.Name.Length > 20)
                {
                    return this.Error("Track name should be between 4 and 20 characters long.");
                }

                if (!input.Link.StartsWith("http"))
                {
                    return this.Error("Please enter a  valid link ");
                }

                if (input.Price < 0)
                {
                    return this.Error("Price should be a positive number");
                }

                this.service.CreateTrack(input.AlbumId, input.Name, input.Link, input.Price);

                return this.Redirect($"/Album/Details?id={input.AlbumId}");
            }

            return this.Redirect("/Users/Login");
        }

        public HttpResponse Details(string id)
        {

            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("Users/Login");
            }


                var viewModel = this.service.Details(id);

            if (viewModel == null)
            {
                return this.Error("Track not found");
            }
            return this.View(viewModel);
        }
    }
}
