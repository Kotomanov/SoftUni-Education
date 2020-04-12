namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class InputAddressViewModel
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
    }
}
