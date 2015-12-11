namespace proof_of_concept_mvc.Domain.Users.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    using proof_of_concept_mvc.Domain.Users.Models;

    public class AspNetUserClaimMap : EntityTypeConfiguration<AspNetUserClaim>
    {
        public AspNetUserClaimMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.UserId)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            ToTable("AspNetUserClaims");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.ClaimType).HasColumnName("ClaimType");
            Property(t => t.ClaimValue).HasColumnName("ClaimValue");

            // Relationships
            HasRequired(t => t.AspNetUser)
                .WithMany(t => t.AspNetUserClaims)
                .HasForeignKey(d => d.UserId);

        }
    }
}
