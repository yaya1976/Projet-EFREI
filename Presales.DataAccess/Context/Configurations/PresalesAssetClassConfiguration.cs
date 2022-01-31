using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesAssetClassConfiguration : IEntityTypeConfiguration<AssetClass>

    {

        public void Configure(EntityTypeBuilder<AssetClass> builder)
        {
            // mapping entre mon modele C# et ma table name
            builder.ToTable("ASSETCLASSES", "dbo");

            builder.HasKey(cac => cac.IdAssetClass);
            
        }

    }
}
