using System;

namespace HowToTrainWebApi.Domain.Entities
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Nome { get; set; }
        public int IndicadorRegistro { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataInlusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public int EnderecoId { get; set; }

        public Endereco Endereco { get; set; }
        public Login Login { get; set; }
    }
}
