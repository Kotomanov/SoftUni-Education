namespace EGovernment.Data.Models.Models.People
{
    using EGovernment.Data.Models.Models.Geographical;

    public interface IPerson
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public int AddressId { get; set; }
    }
}
