namespace EGovernment.Web.ViewModels.AppViewModels.MinistriesViewModels
{

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Services.Mapping;

    public class DisplayAllMinistriesList : IMapFrom<Ministry>
    {
        public string Name { get; set; }

        public Address AddressDetails { get; set; } // ?? AddressDetails does not work not sure why

        public string PictureLink { get; set; }

        public string Url { get; set; }
    }
}
