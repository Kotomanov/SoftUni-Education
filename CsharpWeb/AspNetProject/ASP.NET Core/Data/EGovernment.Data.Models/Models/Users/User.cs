namespace EGovernment.Data.Models.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class User : ApplicationUser
    {
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        public string ImageUrl { get; set; }
    }
}
