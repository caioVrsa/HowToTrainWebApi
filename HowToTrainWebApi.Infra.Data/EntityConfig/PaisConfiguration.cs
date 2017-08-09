using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntityConfig
{
    public class PaisConfiguration : EntityTypeConfiguration<Pais>
    {
        public PaisConfiguration()
        {
            HasKey(p => p.PaisId);
            Property(p => p.Nome).IsRequired().HasMaxLength(50);
        }
    }
}
