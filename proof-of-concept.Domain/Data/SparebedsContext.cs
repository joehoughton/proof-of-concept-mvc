using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using proof_of_concept.Domain.Models.Mapping;

namespace proof_of_concept.Domain.Models
{
    using proof_of_concept.Domain.Models.Mapping;
    using proof_of_concept.Models.Users.Models;

    public partial class SparebedsContext : DbContext
    {
        static SparebedsContext()
        {
            Database.SetInitializer<SparebedsContext>(null);
        }

        public SparebedsContext()
            : base("Name=SparebedsContext")
        {
        }

        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
        }
    }
}
