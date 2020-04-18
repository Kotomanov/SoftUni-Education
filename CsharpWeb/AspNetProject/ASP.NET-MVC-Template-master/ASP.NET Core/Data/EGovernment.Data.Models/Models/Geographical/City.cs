namespace EGovernment.Data.Models.Models.Geographical
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;

    public class City : BaseDeletableModel<int>
    {
        public City()
        {
            this.Addresses = new HashSet<Address>();
        }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int DistrictId { get; set; }

        public virtual District District { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
