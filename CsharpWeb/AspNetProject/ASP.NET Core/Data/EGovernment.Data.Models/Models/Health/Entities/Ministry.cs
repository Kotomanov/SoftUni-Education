namespace EGovernment.Data.Models.Models.Health.Entities
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Entities;
    using EGovernment.Data.Models.Models.Geographical;

    public class Ministry : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        public Address Address { get; set; }

        [Url]
        public string Url { get; set; }

        public MinistryCode MinistryCode { get; set; }
    }
}
