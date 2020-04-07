namespace EGovernment.Data.Models.Enums.Roles
{
    using System.ComponentModel;

    public enum DoctorSpecialty
    {
        Allergist = 0,
        Immunologist = 1,
        Anesthesiologist = 2,
        Cardiologist = 3,
        Dermatologist = 4,
        Endocrinologist = 5,
        Emergency = 6,
        Gastroenterologist = 7,
        Hematologist = 8,
        [Description("Infectious Disease Specialists")]
        InfectiousDiseaseSpecialists = 9,
        Internist = 10,
        Nephrologist = 11,
        Neurologist = 12,
        Gynecologist = 13,
        Oncologist = 14,
        Ophthalmologist = 15,
        Otolaryngologist = 16,
        Pathologist = 17,
        Pediatrician = 18,
        Physiatrist = 19,
        [Description("Plastic Surgeon")]
        PlasticSurgeon = 20,
        Psychiatrist = 21,
        Pulmonologist = 22,
        Radiologist = 23,
        Rheumatologist = 24,
        Surgeon = 25,
        Urologist = 26,
    }
}
