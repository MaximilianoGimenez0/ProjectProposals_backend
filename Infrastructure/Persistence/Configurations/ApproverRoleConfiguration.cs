using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class ApproverRoleConfiguration : IEntityTypeConfiguration<ApproverRole>
    {
        public void Configure(EntityTypeBuilder<ApproverRole> builder)
        {
            builder.ToTable("ApproverRole");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(25);
        }
    }
}