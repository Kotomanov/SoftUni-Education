namespace EGovernment.Web.Areas.Reporting.ViewModels
{
    using System.Collections.Generic;

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;
    using EGovernment.Web.ViewModels.AppViewModels.AddressViewModels;

    public class SearchAndDisplayViewModel : IMapFrom<Address>
    {
        public SearchByCountryViewModel Search { get; set; }

        public ICollection<DisplayAllAddressesViewModel> AddressesList { get; set; }
    }
}
