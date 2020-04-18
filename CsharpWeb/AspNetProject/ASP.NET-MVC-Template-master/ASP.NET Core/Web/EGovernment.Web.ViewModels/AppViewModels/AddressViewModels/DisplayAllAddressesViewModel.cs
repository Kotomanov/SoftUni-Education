namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class DisplayAllAddressesViewModel : IMapFrom<Address>
    {
        public string Country { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public string AddressDetails { get; set; }
    }
}
