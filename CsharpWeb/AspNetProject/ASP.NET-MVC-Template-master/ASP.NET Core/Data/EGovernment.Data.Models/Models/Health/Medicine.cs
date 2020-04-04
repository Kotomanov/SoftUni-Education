namespace EGovernment.Data.Models.Models.Health
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;

    public class Medicine : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        [Range(1, 1000_000)]
        public int AvailableQuantity { get; set; }

        [Range(1, int.MaxValue)]
        public int TotalQuantity { get; set; }
    }
}
