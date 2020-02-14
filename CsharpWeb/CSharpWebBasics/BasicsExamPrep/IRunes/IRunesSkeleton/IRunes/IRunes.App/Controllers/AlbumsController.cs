using IRunes.App.Services;
using IRunes.App.ViewModels.Albums;
using SIS.HTTP;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumService service;
        public AlbumsController(IAlbumService service)
        {
            this.service = service;
        }
        public HttpResponse All()
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var viewAlbums = new AllAlbumsViewModel
            {
                Albums = this.service.GetAllAlbums()
            };

            return this.View(viewAlbums);

        }
       
        public HttpResponse Create()
        {
            if (!IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();

        }

        [HttpPost]
        public HttpResponse Create(CreateInputModel inputModel)
        {

            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (inputModel.Name.Length < 4 || inputModel.Name.Length > 20)
            {
                return this.Error("Album name needs to be between 4 and 20 characters long.");
            }

            if (string.IsNullOrWhiteSpace(inputModel.Cover))
            {
                return this.Error("Cover is needed.");
            }

            this.service.CreateAlbum(inputModel.Name, inputModel.Cover);

            return this.Redirect("/Albums/All");

        }

        public HttpResponse Details(string id)
        {
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect("/Users/Login");
            }


            var viewModel = this.service.Getdetails(id);

            return this.View(viewModel);
        }
    }
}
