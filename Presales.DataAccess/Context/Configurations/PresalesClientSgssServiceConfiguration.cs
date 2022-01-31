using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesClientSgssServiceConfiguration : IEntityTypeConfiguration<ClientSgssService>


    {
        public void Configure(EntityTypeBuilder<ClientSgssService> builder)
        {
            builder.HasKey(q => q.IdService);// définir id 
            builder.ToTable("CLIENT_SGSS_SERVICIES");

        }


    }
}
