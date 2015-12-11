namespace proof_of_concept_mvc.Domain.Users.Models
{
    using System;
    using System.Collections.Generic;

    public class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new List<AspNetUserClaim>();
            AspNetUserLogins = new List<AspNetUserLogin>();
            UserDetails = new List<UserDetail>();
            AspNetRoles = new List<AspNetRole>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
