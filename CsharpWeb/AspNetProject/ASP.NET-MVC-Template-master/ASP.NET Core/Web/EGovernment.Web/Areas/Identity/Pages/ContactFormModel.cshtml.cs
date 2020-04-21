namespace EGovernment.Web.Areas.Identity.Pages
{
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    using EGovernment.Services.Messaging;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    [Authorize]
    public class ContactFormModel : PageModel
    {
        private readonly IEmailSender sender;

        public ContactFormModel(IEmailSender sender)
        {
            this.sender = sender;
        }

        [Required]
        [Display(Name = "Your name*")]
        [StringLength(100, MinimumLength = 5)]
        [BindProperty]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail*")]
        [BindProperty]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        [BindProperty]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Topic*")]
        [BindProperty]
        public string Topic { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 10)]
        [Display(Name = "Message*")]
        [BindProperty]
        public string InputText { get; set; }

        public string InfoMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (this.ModelState.IsValid)
            {
                this.InfoMessage = "You have successfully submitted your feedback";
                await this.sender.SendEmailAsync("mirobg84@yahoo.com", "user", "mirobg84@yahoo.com", "hello", "<h3>Share your thoughts with us</h3>");
                return this.Redirect("/");

                // send mail  does not yet work
            }

            return this.Page();
        }
    }
}
