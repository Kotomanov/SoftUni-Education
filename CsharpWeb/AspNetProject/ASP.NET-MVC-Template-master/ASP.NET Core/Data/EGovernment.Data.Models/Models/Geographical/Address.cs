namespace EGovernment.Data.Models.Models.Geographical
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums;
    using EGovernment.Data.Models.Enums.Geography;

    public class Address : BaseDeletableModel<int>
    {
        [Required]
        public int CountryId { get; set; }

        [Required]
        public int DistrictId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string AddressDetails { get; set; }

        // Geolocation?
    }
}
