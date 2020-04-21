namespace EGovernment.Web.ViewModels.AppViewModels.CitiesViewModels
{
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class DisplayCityViewModel : IMapFrom<City>
    {
        public string Name { get; set; }

        public string DistrictName { get; set; } // may not work because of VIRTUAL ...???

        public string DistrictCountryName { get; set; }
    }
}
