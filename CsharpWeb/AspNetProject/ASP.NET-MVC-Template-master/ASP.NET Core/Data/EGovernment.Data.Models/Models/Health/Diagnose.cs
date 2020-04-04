namespace EGovernment.Data.Models.Models.Health
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;

    public class Diagnose : BaseDeletableModel<int>
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }
    }
}
