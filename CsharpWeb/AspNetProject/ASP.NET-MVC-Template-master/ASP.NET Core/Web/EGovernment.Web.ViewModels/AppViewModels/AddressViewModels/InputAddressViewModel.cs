namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class InputAddressViewModel : IMapTo<Address>
    {
        [Required]
        [Display(Name = "Country*")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "District*")]
        public int DistrictId { get; set; }

        [Required]
        [Display(Name = "City*")]
        public string CityName { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code*")]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        [Display(Name = "Address details*")]
        public string AddressDetails { get; set; }
    }
}
