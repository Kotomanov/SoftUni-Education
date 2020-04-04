// ReSharper disable VirtualMemberCallInConstructor
namespace EGovernment.Data.Models
{
    using System;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models.Enums.Roles;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public Role RoleCode { get; set; } // check if it works on other than Admin?

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
