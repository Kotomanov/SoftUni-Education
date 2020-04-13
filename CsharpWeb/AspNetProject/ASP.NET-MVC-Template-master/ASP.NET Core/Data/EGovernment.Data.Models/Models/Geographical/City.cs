namespace EGovernment.Data.Models.Models.Geographical
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;

    public class City : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}
