namespace proof_of_concept_mvc.Domain.Users.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    using proof_of_concept_mvc.Domain.Users.Models;

    public class AspNetRoleMap : EntityTypeConfiguration<AspNetRole>
    {
        public AspNetRoleMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            ToTable("AspNetRoles");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");

            // Relationships
            HasMany(t => t.AspNetUsers)
                .WithMany(t => t.AspNetRoles)
                .Map(m =>
                    {
                        m.ToTable("AspNetUserRoles");
                        m.MapLeftKey("RoleId");
                        m.MapRightKey("UserId");
                    });

        }
    }
}
