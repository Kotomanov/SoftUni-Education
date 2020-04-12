namespace EGovernment.Data.Models.Models.Geographical
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Geography;

    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.Districts = new HashSet<District>();
        }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        public virtual CountryCode CountryCode { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}
