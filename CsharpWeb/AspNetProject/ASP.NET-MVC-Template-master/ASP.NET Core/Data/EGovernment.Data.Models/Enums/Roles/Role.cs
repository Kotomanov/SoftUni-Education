﻿namespace EGovernment.Data.Models.Enums.Roles
{
    using System.ComponentModel;

    public enum Role
    {
        Administrator = 0,
        Moderator = 1,
        Patient = 2,
        Doctor = 3,
        HR = 4,
        Janitor = 5,
        Driver = 6,
        IT = 7,
        Nurse = 8,
        Guard = 9,
        Intern = 10,
        [Description("Head Of Department")]
        HeadOfDepartment = 11,
        Magician = 12,
        Pharmacist = 13,
    }
}
