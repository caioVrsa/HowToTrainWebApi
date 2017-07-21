namespace HowToTrainWebApi.Domain.Entities
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public Estado Estado { get; set; }
        public Endereco Endereco { get; set; }
    }
}
