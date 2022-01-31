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
    public class PresalesClientLocalAumConfiguration : IEntityTypeConfiguration<ClientLocalAum>

    {
        
        public void Configure(EntityTypeBuilder<ClientLocalAum> builder)
        {
            builder.ToTable("LOCAL_AUM", "dbo");
            builder.HasKey(q => q.IdLocalAum);// définir id 


        }
    }
}
