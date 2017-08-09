using System;
using HowToTrainWebApi.Domain.Entities;

namespace HowToTrainWebApi.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.HowToTrainWebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.HowToTrainWebApiContext context)
        {
            context.Paises.AddOrUpdate(new Pais() { PaisId = 1, Nome = "Brasil"});

            context.Estados.AddOrUpdate(
                new Estado() { EstadoId = 1, Nome = "SP", PaisId = 1 },
                new Estado() { EstadoId = 2, Nome = "MG", PaisId = 1 },
                new Estado() { EstadoId = 3, Nome = "RJ", PaisId = 1 });

            context.Cidades.AddOrUpdate(
                new Cidade() { CidadeId = 1, Nome = "São Paulo", EstadoId = 1},
                new Cidade() { CidadeId = 2, Nome = "Suzano", EstadoId = 1 },
                new Cidade() { CidadeId = 3, Nome = "Mogi das Cruzes", EstadoId = 1 });

            context.Enderecos.AddOrUpdate(
                new Endereco()
                { EnderecoId = 1, Logradouro = "Rua Admin", Bairro = "Bairro Admin", CEP = "01010010",
                    Complemento = "Complemento Admin", Numero = 1, CidadeId = 1
                });

            context.Registros.AddOrUpdate(
                new Registro()
                {
                    RegistroId = 1, EnderecoId = 1, Nome = "Admin", Ativo = true, IndicadorRegistro = 1
                });

            context.Logins.AddOrUpdate(
                new Login()
                {
                    LoginId = 1, Email = "admin@adminhtt.com", Senha = "HTTadmin@123", RegistroId = 1
                });

            base.Seed(context);
        }
    }
}
