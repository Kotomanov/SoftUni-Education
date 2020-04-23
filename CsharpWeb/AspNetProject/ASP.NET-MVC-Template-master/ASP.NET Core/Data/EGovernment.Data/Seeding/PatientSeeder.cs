namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EGovernment.Data.Models.Models.Health;
    using EGovernment.Data.Models.Models.People;

    internal class PatientSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Patient> patientsList = new List<Patient>();
            var medRecordId = dbContext.MedicalRecords.First().Id;

            var patient1 = new Patient
            {
                FirstName = "Bat",
                LastName = "Boiko",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 19,
                MedicalRecordId = medRecordId,
            };

            var patient2 = new Patient
            {
                FirstName = "Djehide ",
                LastName = "Karaoglu",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 18,
                MedicalRecordId = ++medRecordId,
            };

            var patient3 = new Patient
            {
                FirstName = "Mumun ",
                LastName = "Hassan",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 18,
                MedicalRecordId = ++medRecordId,
            };

            var patient4 = new Patient
            {
                FirstName = "Suhan",
                LastName = "Alemdarolu",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 47,
                MedicalRecordId = ++medRecordId,
            };

            var patient5 = new Patient
            {
                FirstName = "Siham",
                LastName = "Sihamova",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 47,
                MedicalRecordId = ++medRecordId,
            };

            var patient6 = new Patient
            {
                FirstName = "Farukh",
                LastName = "Buran",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 40,
                MedicalRecordId = ++medRecordId,
            };

            var patient7 = new Patient
            {
                FirstName = "Esma",
                LastName = "Sultan",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 4,
                MedicalRecordId = ++medRecordId,
            };

            var patient8 = new Patient
            {
                FirstName = "Ali",
                LastName = "Rezza",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 4,
                MedicalRecordId = ++medRecordId,
            };

            var patient9 = new Patient
            {
                FirstName = "Gino",
                LastName = "Dupkorovoff",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 41,
                MedicalRecordId = ++medRecordId,
            };

            var patient10 = new Patient
            {
                FirstName = "Djesur",
                LastName = "Karahasanolu",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 41,
                MedicalRecordId = ++medRecordId,
            };

            var patient11 = new Patient
            {
                FirstName = "Bade",
                LastName = "Bidem",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 33,
                MedicalRecordId = ++medRecordId,
            };

            var patient12 = new Patient
            {
                FirstName = "Ohne",
                LastName = "Boly",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 33,
                MedicalRecordId = ++medRecordId,
            };

            var patient13 = new Patient
            {
                FirstName = "Adalet",
                LastName = "Mehmetolu",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 32,
                MedicalRecordId = ++medRecordId,
            };

            var patient14 = new Patient
            {
                FirstName = "Kumar",
                LastName = "Vinot",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 30,
                MedicalRecordId = ++medRecordId,
            };

            var patient15 = new Patient
            {
                FirstName = "Amador",
                LastName = "Rivas",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 32,
                MedicalRecordId = ++medRecordId,
            };

            var patient16 = new Patient
            {
                FirstName = "Lola",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 10,
                MedicalRecordId = ++medRecordId,
            };

            var patient17 = new Patient
            {
                FirstName = "Berta",
                LastName = "Escobar",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 11,
                MedicalRecordId = ++medRecordId,
            };

            var patient18 = new Patient
            {
                FirstName = "Enrique",
                LastName = "Pastor",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 21,
                MedicalRecordId = ++medRecordId,
            };

            var patient19 = new Patient
            {
                FirstName = "Maite",
                LastName = "Figueroa",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 22,
                MedicalRecordId = ++medRecordId,
            };

            var patient20 = new Patient
            {
                FirstName = "Coque",
                LastName = "Calatrava",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 27,
                MedicalRecordId = ++medRecordId,
            };

            var patient21 = new Patient
            {
                FirstName = "Rizwan",
                LastName = "Nioka",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 28,
                MedicalRecordId = ++medRecordId,
            };

            var patient22 = new Patient
            {
                FirstName = "Araceli",
                LastName = "Madariaga",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 28,
                MedicalRecordId = ++medRecordId,
            };

            var patient23 = new Patient
            {
                FirstName = "Raquel",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 18,
                MedicalRecordId = ++medRecordId,
            };

            var patient24 = new Patient
            {
                FirstName = "Estela",
                LastName = "Reynolds",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 6,
                MedicalRecordId = ++medRecordId,
            };

            var patient25 = new Patient
            {
                FirstName = "Leonardo",
                LastName = "Romani",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 6,
                MedicalRecordId = ++medRecordId,
            };

            var patient26 = new Patient
            {
                FirstName = "Vicente",
                LastName = "Maroto",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 9,
                MedicalRecordId = ++medRecordId,
            };

            var patient27 = new Patient
            {
                FirstName = "Nines",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 9,
                MedicalRecordId = ++medRecordId,
            };

            var patient28 = new Patient
            {
                FirstName = "Fermín",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 29,
                MedicalRecordId = ++medRecordId,
            };

            var patient29 = new Patient
            {
                FirstName = "Maximo",
                LastName = "Angulo",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 37,
                MedicalRecordId = ++medRecordId,
            };

            var patient30 = new Patient
            {
                FirstName = "Antonio",
                LastName = "Fagaldo",
                EGN = "1234567890",
                AddressId = 1,
                DoctorId = 37,
                MedicalRecordId = ++medRecordId,
            };

            patientsList.Add(patient1);
            patientsList.Add(patient2);
            patientsList.Add(patient3);
            patientsList.Add(patient4);
            patientsList.Add(patient5);
            patientsList.Add(patient6);
            patientsList.Add(patient7);
            patientsList.Add(patient8);
            patientsList.Add(patient9);
            patientsList.Add(patient10);
            patientsList.Add(patient11);
            patientsList.Add(patient12);
            patientsList.Add(patient13);
            patientsList.Add(patient14);
            patientsList.Add(patient15);
            patientsList.Add(patient16);
            patientsList.Add(patient17);
            patientsList.Add(patient18);
            patientsList.Add(patient19);
            patientsList.Add(patient20);
            patientsList.Add(patient21);
            patientsList.Add(patient22);
            patientsList.Add(patient23);
            patientsList.Add(patient24);
            patientsList.Add(patient25);
            patientsList.Add(patient26);
            patientsList.Add(patient27);
            patientsList.Add(patient28);
            patientsList.Add(patient29);
            patientsList.Add(patient30);

            await dbContext.Patients.AddRangeAsync(patientsList);
            await dbContext.SaveChangesAsync();
        }
    }
}
