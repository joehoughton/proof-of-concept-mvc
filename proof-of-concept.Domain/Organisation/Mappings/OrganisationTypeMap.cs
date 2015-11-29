namespace proof_of_concept.Domain.Organisation.Mappings
{
    using System.Data.Entity.ModelConfiguration;
    using proof_of_concept.Domain.Organisation.Models;

    public class OrganisationTypeMap : EntityTypeConfiguration<OrganisationType>
    {
        public OrganisationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrganisationType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");
        }
    }
}
