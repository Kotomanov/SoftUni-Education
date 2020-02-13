using SIS.HTTP;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Controllers
{
    public class AlbumsController : Controller
    {

        public HttpResponse All()
        {
            // if the user is logged in 
            return this.View();

            // if not logged in 
            // return this.Redirect("/Users/Register") //???
        }

        public HttpResponse Create ()
        {
            // if user is logged in 
            return this.View();

            // if not logged in 

        }

        public  HttpResponse Details(int id)
        {
            // if user is logged in 
            return this.View();
        }
    }
}
