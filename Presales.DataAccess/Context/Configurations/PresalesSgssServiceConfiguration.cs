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
    public class PresalesSgssServiceConfiguration : IEntityTypeConfiguration<SgssService>

    {
        public void Configure(EntityTypeBuilder<SgssService> builder)
        {
            builder.ToTable("SGSS_SERVICES");
            builder.HasKey(q => q.IdBdr);// définir id 
           
        }
    }
}

