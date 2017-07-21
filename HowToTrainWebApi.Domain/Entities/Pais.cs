using System.Collections.Generic;

namespace HowToTrainWebApi.Domain.Entities
{
    public class Pais
    {
        public int PaisId { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Estado> Estados { get; set; }
    }
}
