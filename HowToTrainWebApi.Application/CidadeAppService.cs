using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        private readonly ICidadeService _cidadeService;

        public CidadeAppService(ICidadeService cidadeService)
            : base(cidadeService)
        {
            _cidadeService = cidadeService;
        }
    }
}
