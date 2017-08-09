namespace HowToTrainWebApi.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }
        public Registro Registro { get; set; }
    }
}
