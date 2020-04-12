namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using EGovernment.Data.Models.Enums;
    using EGovernment.Data.Models.Enums.Geography;

    public class DisplayAllAddressesViewModel
    {
        public string Country { get; set; }

        public string District { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public string AddressDetails { get; set; }
    }
}
