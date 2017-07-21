using System.Collections.Generic;

namespace HowToTrainWebApi.Domain.Entities
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public int PaisId { get; set; }

        public Pais Pais { get; set; }
        public IEnumerable<Cidade> Cidades { get; set; }
    }
}
