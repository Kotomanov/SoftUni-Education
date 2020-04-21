namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class DisplayAllAddressesViewModel : IMapFrom<Address>
    {
        public int Id { get; set; }

        public string CountryName { get; set; }

        public string DistrictName { get; set; }

        public string CityName { get; set; }

        public int PostalCode { get; set; }

        public string AddressDetails { get; set; }
    }
}
