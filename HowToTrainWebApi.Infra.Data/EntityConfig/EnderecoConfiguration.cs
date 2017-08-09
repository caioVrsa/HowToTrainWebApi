using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(p => p.EnderecoId);
            Property(p => p.Logradouro).IsRequired().HasMaxLength(75);
            Property(p => p.Bairro).IsRequired().HasMaxLength(50);
            Property(p => p.Numero).IsRequired();
            Property(p => p.Complemento).HasMaxLength(250);

            HasRequired(p => p.Cidade).WithMany().HasForeignKey(p => p.CidadeId);
        }
    }
}
