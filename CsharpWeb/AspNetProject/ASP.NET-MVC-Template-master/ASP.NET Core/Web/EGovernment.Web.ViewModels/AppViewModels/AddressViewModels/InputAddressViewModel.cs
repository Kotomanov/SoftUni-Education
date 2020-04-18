﻿namespace EGovernment.Web.ViewModels.AppViewModels.AddressViewModels
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Services.Mapping;

    public class InputAddressViewModel : IMapTo<Address>
    {
        [Required]
        public string CountryName { get; set; }

        [Required]
        public string DistrictName { get; set; }

        [Required]
        public string CityName { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public int PostalCode { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string AddressDetails { get; set; }
    }
}
