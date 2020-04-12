namespace EGovernment.Data.Models.Models.Geographical
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums;

    public class District : BaseDeletableModel<int>
    {
        public District()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public virtual DistrictCode DistrictCode { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
