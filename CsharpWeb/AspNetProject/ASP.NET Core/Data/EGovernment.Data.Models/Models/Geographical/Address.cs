namespace EGovernment.Data.Models.Models.Geographical
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums;
    using EGovernment.Data.Models.Enums.Geography;

    public class Address : BaseDeletableModel<int>
    {
        [Required]
        public Country Country { get; set; }

        [Required]
        public District District { get; set; }

        // TODO find a way to have the city here - reflection?
        [Required]
        public string City { get; set; }

        [Required]
        [Range(4, 6)]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string AddressDetails { get; set; }
    }
}
