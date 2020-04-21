namespace EGovernment.Web.ViewModels.AppViewModels.CountryViewModels
{

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class ListAllCountriesViewModel : IMapFrom<Country>
    {
        public string Name { get; set; }
    }
}
