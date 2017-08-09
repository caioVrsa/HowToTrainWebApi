using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntityConfig
{
    public class RegistroConfiguration : EntityTypeConfiguration<Registro>
    {
        public RegistroConfiguration()
        {
            HasKey(p => p.RegistroId);
            Property(p => p.Nome).IsRequired().HasMaxLength(50);
            Property(p => p.Ativo).IsRequired();
            Property(p => p.DataInlusao).HasColumnType("DateTime2");
            Property(p => p.DataAlteracao).IsOptional().HasColumnType("DateTime2");
            Property(p => p.UltimaAtualizacao).IsOptional().HasColumnType("DateTime2");

            HasRequired(p => p.Endereco).WithMany().HasForeignKey(p => p.EnderecoId);
        }
    }
}
