namespace EGovernment.Web.Areas.Reporting.ViewModels
{
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class SearchByCountryViewModel : IMapFrom<Country>
    {
        public string CountryName { get; set; }
    }
}
