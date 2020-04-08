namespace EGovernment.Data.Models.Enums.Entities
{
    using System.ComponentModel;

    public enum MinistryCode
    {
        Health = 0,
        Interior = 1,
        [Description("Foreign Affairs")]
        ForeignAffairs = 2,
        Justice = 3,
        [Description("Education and Science")]
        EducationAndScience = 4,
        Defense = 5,
        Culture = 6,
        Tourism = 7,
        [Description("External Affairs")]
        ExternalAffairs = 8,
        [Description("Transport Information Technology and Communications")]
        TransportInformationTechnologyAndCommunications = 9,
        [Description("Labor and Social Policy")]
        LaborAndSocialPolicy = 9,
        [Description("Environment and Water")]
        EnvironmentAndWater = 10,
        [Description("Youth and Sports")]
        YouthAndSports = 11,
        [Description("Regional Development and Public Works")]
        RegionalDevelopmentAndPublicWorks = 12,
        Finance = 13,
        Energy = 14,
        [Description("Agriculture, Food and Forestry")]
        AgricultureFoodAndForestry = 15,
        Economy = 16,
    }
}
