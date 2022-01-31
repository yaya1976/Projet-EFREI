using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesClientAssetClassConfiguration : IEntityTypeConfiguration<ClientAssetClass>

    {

        public void Configure(EntityTypeBuilder<ClientAssetClass> builder)
        {
            // mapping entre mon modele C# et ma table name
            builder.ToTable("CLIENTS-ASSETCLASSES", "dbo");

            builder.HasKey(cac => new { cac.IdAssetClass, cac.IdBdr }); 

            builder.HasOne(cac => cac.Client).WithMany(c => c.ClientAssetClasses).HasForeignKey(cp => cp.IdBdr);

            builder.HasOne(cac => cac.AssetClass).WithMany(c => c.ClientAssetClass).HasForeignKey(cp => cp.IdAssetClass);



            //builder.Property(p => p.NotificationIcIdsString).HasColumnName("NotificationIcIds");
        }
    }
}
