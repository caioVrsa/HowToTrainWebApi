using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
            : base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
    }
}
