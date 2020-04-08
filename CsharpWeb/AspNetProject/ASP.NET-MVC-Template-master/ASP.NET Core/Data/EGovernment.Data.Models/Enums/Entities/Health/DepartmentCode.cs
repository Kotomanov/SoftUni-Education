namespace EGovernment.Data.Models.Enums.Entities.Health
{
    using System.ComponentModel;

    public enum DepartmentCode
    {
        Oncology = 0,
        Pediatric = 1,
        Surgery = 2,
        Traumatology = 3,
        Emergency = 4,
        Anesthetics = 5,
        [Description("Burns Center")]
        BurnsCenter = 6,
        Cardiology = 7,
        Chaplaincy = 8,
        IntensiveCare = 9,
        Radiology = 10,
        Gastroenterology = 11,
        Gynecology = 12,
        Haematology = 13,
        [Description("Infection Control")]
        InfectionControl = 14,
        [Description("Medical Records")]
        MedicalRecords = 15,
        Maternity = 16,
        Microbiology = 17,
        Neonatal = 18,
        Nephrology = 19,
        Neurology = 20,
        Ophthalmology = 21,
        Otolaryngology = 22,
        Physiotherapy = 23,
        Rheumatology = 24,
        Urology = 25,
        Finance = 26,
        HR = 27,
        IT = 28,
        [Description("Patients Accounts")]
        PatientsAccounts = 29,
        [Description("Purchasing and Supplies")]
        PurchasingAndSupplies = 30,
    }
}
