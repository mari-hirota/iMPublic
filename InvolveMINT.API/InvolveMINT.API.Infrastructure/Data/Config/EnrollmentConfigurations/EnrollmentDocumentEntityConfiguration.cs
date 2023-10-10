using InvolveMINT.API.Core.EnrollmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvolveMINT.API.Infrastructure.Data.Config.EnrollmentConfigurations
{
  public class EnrollmentDocumentEntityConfiguration : IEntityTypeConfiguration<EnrollmentDocumentEntity>
  {
    public void Configure(EntityTypeBuilder<EnrollmentDocumentEntity> builder)
    {
      builder.ToTable("EnrollmentDocument");

      builder.Property(e => e.Id)
          .HasColumnName("id")
          .HasColumnType("text")
          .IsRequired();

      // Define relationships with Guid IDs
      builder.Property(e => e.PassportDocumentId)
        .HasColumnName("passportDocumentId")
        .HasColumnType("text");

      builder.Property(e => e.ProjectDocumentId).HasColumnName("projectDocumentId")
        .HasColumnType("text");

      builder.Property(e => e.EnrollmentId).HasColumnName("enrollmentId")
        .HasColumnType("text");

      // Configure any other specific entity configurations here
    }
  }
}
