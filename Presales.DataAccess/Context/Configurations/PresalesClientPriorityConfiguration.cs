using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesClientPriorityConfiguration : IEntityTypeConfiguration<ClientPriority>

    {
        public void Configure(EntityTypeBuilder<ClientPriority> builder)
        {
            builder.ToTable("CLIENT_PRIORITIES", "dbo");

           
            builder.HasKey(cp => new { cp.IdPriority, cp.IdBdr });

            builder.HasOne(cp => cp.Client).WithMany(c => c.ClientPriorities).HasForeignKey(cp => cp.IdBdr);

            builder.HasOne(cp => cp.Priority).WithMany(c => c.ClientPriorities).HasForeignKey(cp => cp.IdPriority);

        }
    }
}