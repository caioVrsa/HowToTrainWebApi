using System.Data.Entity.ModelConfiguration;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.EntityConfig
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
            HasKey(p => p.LoginId);
            Property(p => p.Senha).IsRequired();
            Property(p => p.Email).IsRequired();

            HasRequired(p => p.Registro).WithMany().HasForeignKey(p => p.RegistroId);
        }
    }
}
