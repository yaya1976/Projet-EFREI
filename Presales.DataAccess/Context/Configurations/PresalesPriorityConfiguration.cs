using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Presales.Entity;

namespace Presales.DataAccess.Context.Configurations
{
    public class PresalesPriorityConfiguration : IEntityTypeConfiguration<Priority>

    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.ToTable("PRIORITIES");

            builder.HasKey(cp => cp.IdPriority);// définir id 


        }
    }
}