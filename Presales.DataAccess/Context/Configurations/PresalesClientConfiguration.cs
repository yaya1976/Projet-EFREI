using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("CLIENTS", "dbo");

            builder.HasKey(q=>q.IdBdr);// définir id 
            builder.HasMany(q => q.ClientPriorities).WithOne(c => c.Client).HasForeignKey(c => c.IdPriority);
            builder.HasMany(q => q.ClientAssetClasses).WithOne(c => c.Client).HasForeignKey(c => c.IdAssetClass);
            builder.HasMany(q => q.ClientLocalAums).WithOne(c => c.Client).HasForeignKey(c => c.IdLocalAum);
            builder.HasMany(q => q.ClientSgssServices).WithOne(c => c.Client).HasForeignKey(c => c.IdService);

        }
    }
}
