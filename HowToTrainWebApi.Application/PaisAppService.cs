using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class PaisAppService : AppServiceBase<Pais>, IPaisAppService
    {
        private readonly IPaisService _paisService;

        public PaisAppService(IPaisService  paisService) 
            : base(paisService)
        {
            _paisService = paisService;
        }
    }
}
