using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntityConfig
{
    public class CidadeConfiguration : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {
            HasKey(p => p.CidadeId);
            Property(p => p.Nome).IsRequired().HasMaxLength(50);

            HasRequired(p => p.Estado).WithMany().HasForeignKey(p => p.EstadoId);
        }
    }
}
