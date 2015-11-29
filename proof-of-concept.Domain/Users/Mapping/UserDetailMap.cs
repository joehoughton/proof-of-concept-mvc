namespace proof_of_concept.Domain.Users.Mapping
{
    using System.Data.Entity.ModelConfiguration;
    using proof_of_concept.Domain.Users.Models;

    public class UserDetailMap : EntityTypeConfiguration<UserDetail>
    {
        public UserDetailMap()
        {
        // Primary Key
        this.HasKey(t => t.Id);

        // Properties
        this.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(50);

        this.Property(t => t.Telephone)
            .IsRequired()
            .HasMaxLength(11);

        this.Property(t => t.Mobile)
            .IsRequired()
            .HasMaxLength(11);

        this.Property(t => t.AspNetUserId)
            .IsRequired()
            .HasMaxLength(128);

        // Table & Column Mappings
        this.ToTable("UserDetails");
        this.Property(t => t.Id).HasColumnName("Id");
        this.Property(t => t.Name).HasColumnName("Name");
        this.Property(t => t.Telephone).HasColumnName("Telephone");
        this.Property(t => t.Mobile).HasColumnName("Mobile");
        this.Property(t => t.EmailNotification).HasColumnName("EmailNotification");
        this.Property(t => t.SmsNotification).HasColumnName("SmsNotification");
        this.Property(t => t.AspNetUserId).HasColumnName("AspNetUserId");
        this.Property(t => t.OrganisationId).HasColumnName("OrganisationId");

        // Relationships
        this.HasRequired(t => t.AspNetUser)
            .WithMany(t => t.UserDetails)
            .HasForeignKey(d => d.AspNetUserId);
        this.HasRequired(t => t.Organisation)
            .WithMany()
            .HasForeignKey(d => d.OrganisationId);
        }
    }
}
