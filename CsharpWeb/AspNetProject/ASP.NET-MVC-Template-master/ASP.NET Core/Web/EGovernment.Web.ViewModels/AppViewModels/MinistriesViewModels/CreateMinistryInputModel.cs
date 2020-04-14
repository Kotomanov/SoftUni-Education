namespace EGovernment.Web.ViewModels.AppViewModels.MinistriesViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateMinistryInputModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Url]
        public string PictureLink { get; set; }

        [Url]
        public string Url { get; set; }

        public int MinistryCode { get; set; }
    }
}
