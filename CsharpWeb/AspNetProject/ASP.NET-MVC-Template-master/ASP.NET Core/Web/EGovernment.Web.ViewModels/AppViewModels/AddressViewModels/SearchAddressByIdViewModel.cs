namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class SearchAddressByIdViewModel : IMapTo<Address>
    {
        [Required]
        [Display(Name = "Address identificator*")]
        [Range(1, 100_000)]
        public int Id { get; set; }
    }
}
