namespace EGovernment.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using EGovernment.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly Cloudinary cloudinary;

        public HomeController(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        // public async Task<IActionResult> Upload(ICollection<IFormFile> files)
        // {
        //    var uploadParams = new ImageUploadParams()
        //    {
        //        File = new FileDescription(@""),
        //    };
        //    var uploadResult = await this.cloudinary.UploadAsync(uploadParams);

        // return this.Redirect("/");

        // }
        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult LearningAndWorking()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
