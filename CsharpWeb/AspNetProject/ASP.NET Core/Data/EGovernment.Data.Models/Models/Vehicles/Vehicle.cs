namespace EGovernment.Data.Models.Models.Vehicles
{
    using System.ComponentModel.DataAnnotations;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Vehicles;

    public class Vehicle : BaseDeletableModel<int>
    {
        [Required]
        [RegularExpression(@"\b[^DFIJLQRSUVWYZ]{1,2}[0-9]{4}[^DFIJLQRSUVWYZ]{2}\b")]
        public string CarPlate { get; set; }

        [Required]
        [RegularExpression(@"\b[A-Z]+[A-Za-z]*\b")]
        public string Made { get; set; }

        [Required]
        [RegularExpression(@"\b\w+\b")] // check if it will work
        public string Model { get; set; }

        [Required]
        public VehicleType VehicleType { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        [Required]
        [Range(1, 2_000_000)]
        public int Millage { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string VIN { get; set; }

        [Required]
        [Range(1, 50)]
        public int PassangersCapacity { get; set; }

        // TODO Add driver in a Hashset perhaps?
    }
}
