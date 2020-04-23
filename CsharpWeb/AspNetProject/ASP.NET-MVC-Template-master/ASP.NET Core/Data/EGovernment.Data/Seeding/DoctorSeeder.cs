namespace EGovernment.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EGovernment.Data.Models.Models.People;

    internal class DoctorSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<Doctor> doctorsList = new List<Doctor>();

            var doctor = new Doctor
            {
                FirstName = "Surueya",
                LastName = "Burak",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor1 = new Doctor
            {
                FirstName = "Bat",
                LastName = "Boiko",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor2 = new Doctor
            {
                FirstName = "Djehide ",
                LastName = "Karaoglu",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor3 = new Doctor
            {
                FirstName = "Mumun ",
                LastName = "Hassan",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor4 = new Doctor
            {
                FirstName = "Suhan",
                LastName = "Alemdarolu",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor5 = new Doctor
            {
                FirstName = "Siham",
                LastName = "Sihamova",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor6 = new Doctor
            {
                FirstName = "Farukh",
                LastName = "Buran",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor7 = new Doctor
            {
                FirstName = "Esma",
                LastName = "Sultan",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor8 = new Doctor
            {
                FirstName = "Ali",
                LastName = "Rezza",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor9 = new Doctor
            {
                FirstName = "Gino",
                LastName = "Dupkorovoff",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor10 = new Doctor
            {
                FirstName = "Djesur",
                LastName = "Karahasanolu",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor11 = new Doctor
            {
                FirstName = "Bade",
                LastName = "Bidem",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor12 = new Doctor
            {
                FirstName = "Ohne",
                LastName = "Boly",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor13 = new Doctor
            {
                FirstName = "Adalet",
                LastName = "Mehmetolu",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor14 = new Doctor
            {
                FirstName = "Kumar",
                LastName = "Vinot",
                EGN = "1234567890",
                AddressId = 1,

            };

            var doctor15 = new Doctor
            {
                FirstName = "Amador",
                LastName = "Rivas",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor16 = new Doctor
            {
                FirstName = "Lola",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor17 = new Doctor
            {
                FirstName = "Berta",
                LastName = "Escobar",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor18 = new Doctor
            {
                FirstName = "Enrique",
                LastName = "Pastor",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor19 = new Doctor
            {
                FirstName = "Maite",
                LastName = "Figueroa",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor20 = new Doctor
            {
                FirstName = "Coque",
                LastName = "Calatrava",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor21 = new Doctor
            {
                FirstName = "Rizwan",
                LastName = "Nioka",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor22 = new Doctor
            {
                FirstName = "Araceli",
                LastName = "Madariaga",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor23 = new Doctor
            {
                FirstName = "Raquel",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor24 = new Doctor
            {
                FirstName = "Estela",
                LastName = "Reynolds",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor25 = new Doctor
            {
                FirstName = "Leonardo",
                LastName = "Romani",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor26 = new Doctor
            {
                FirstName = "Vicente",
                LastName = "Maroto",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor27 = new Doctor
            {
                FirstName = "Nines",
                LastName = "Villanueva",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor28 = new Doctor
            {
                FirstName = "Fermín",
                LastName = "Trujillo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor29 = new Doctor
            {
                FirstName = "Maximo",
                LastName = "Angulo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor30 = new Doctor
            {
                FirstName = "Antonio",
                LastName = "Fagaldo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor31 = new Doctor
            {
                FirstName = "Rosario",
                LastName = "Parrales",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor32 = new Doctor
            {
                FirstName = "Teodoro",
                LastName = "Rivas",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor33 = new Doctor
            {
                FirstName = "Yolanda",
                LastName = "Morcillo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor34 = new Doctor
            {
                FirstName = "Dina",
                LastName = "Stoeva",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor35 = new Doctor
            {
                FirstName = "Michael",
                LastName = "Petrov",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor36 = new Doctor
            {
                FirstName = "Mihail",
                LastName = "Traichev",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor37 = new Doctor
            {
                FirstName = "Garderobcho",
                LastName = "Ivanov",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor38 = new Doctor
            {
                FirstName = "Nu",
                LastName = "Pogodi",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor39 = new Doctor
            {
                FirstName = "Tomi",
                LastName = "Djeri",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor40 = new Doctor
            {
                FirstName = "Kumcho",
                LastName = "Vulkan",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor41 = new Doctor
            {
                FirstName = "Kuma",
                LastName = "Lisana",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor42 = new Doctor
            {
                FirstName = "Lady",
                LastName = "Gabba",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor43 = new Doctor
            {
                FirstName = "Shushana",
                LastName = "Dimitrova",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor44 = new Doctor
            {
                FirstName = "Chicho",
                LastName = "Potyo",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor45 = new Doctor
            {
                FirstName = "Profesor",
                LastName = "Maitapchyiski",
                EGN = "1234567890",
                AddressId = 1,
            };

            var doctor46 = new Doctor
            {
                FirstName = "La",
                LastName = "Chusa",
                EGN = "1234567890",
                AddressId = 1,
            };

            doctorsList.Add(doctor);
            doctorsList.Add(doctor1);
            doctorsList.Add(doctor2);
            doctorsList.Add(doctor3);
            doctorsList.Add(doctor4);
            doctorsList.Add(doctor5);
            doctorsList.Add(doctor6);
            doctorsList.Add(doctor7);
            doctorsList.Add(doctor8);
            doctorsList.Add(doctor9);
            doctorsList.Add(doctor10);
            doctorsList.Add(doctor11);
            doctorsList.Add(doctor12);
            doctorsList.Add(doctor13);
            doctorsList.Add(doctor14);
            doctorsList.Add(doctor15);
            doctorsList.Add(doctor16);
            doctorsList.Add(doctor17);
            doctorsList.Add(doctor18);
            doctorsList.Add(doctor19);
            doctorsList.Add(doctor20);
            doctorsList.Add(doctor21);
            doctorsList.Add(doctor22);
            doctorsList.Add(doctor23);
            doctorsList.Add(doctor24);
            doctorsList.Add(doctor25);
            doctorsList.Add(doctor26);
            doctorsList.Add(doctor27);
            doctorsList.Add(doctor28);
            doctorsList.Add(doctor29);
            doctorsList.Add(doctor30);
            doctorsList.Add(doctor31);
            doctorsList.Add(doctor32);
            doctorsList.Add(doctor33);
            doctorsList.Add(doctor34);
            doctorsList.Add(doctor35);
            doctorsList.Add(doctor36);
            doctorsList.Add(doctor37);
            doctorsList.Add(doctor38);
            doctorsList.Add(doctor39);
            doctorsList.Add(doctor40);
            doctorsList.Add(doctor41);
            doctorsList.Add(doctor42);
            doctorsList.Add(doctor43);
            doctorsList.Add(doctor44);
            doctorsList.Add(doctor45);
            doctorsList.Add(doctor46);

            await dbContext.AddRangeAsync(doctorsList);
            await dbContext.SaveChangesAsync();
        }
    }
}
