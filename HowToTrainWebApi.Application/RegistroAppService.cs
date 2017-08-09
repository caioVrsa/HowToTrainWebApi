using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class RegistroAppService : AppServiceBase<Registro>, IRegistroAppService
    {
        private readonly IRegistroService _registroService;

        public RegistroAppService(IRegistroService registroService)
            : base(registroService)
        {
            _registroService = registroService;
        }
    }
}
