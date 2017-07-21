using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntotyConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(p => p.EstadoId);
            Property(p => p.Nome).IsRequired().HasMaxLength(50);

            HasRequired(p => p.Pais).WithMany().HasForeignKey(p => p.PaisId);
        }
    }
}
