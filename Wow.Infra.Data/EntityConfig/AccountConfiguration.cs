using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Wow.Domain.Entities;

namespace Wow.Infra.Data.EntityConfig
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(account => account.Guid);
            
            builder.Property(account => account.HolderAccountName)
                .IsRequired()
                .HasColumnType("nvarchar(250)");

            builder.Property(account => account.AccountNumber)
                .IsRequired()
                .HasColumnType("nvarchar(8)");
        }
    }
}