using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(25);

            builder.HasOne(p => p.UserRole)
                .WithMany(c => c.Users)
                .HasForeignKey(p => p.Role)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}