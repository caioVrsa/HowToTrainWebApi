using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Domain.Services
{
    public class RegistroService : ServiceBase<Registro>, IRegistroService
    {
        private readonly IRegistroRepository _registroRepository;

        public RegistroService(IRegistroRepository registroRepository)
            : base(registroRepository)
        {
            _registroRepository = registroRepository;
        }
    }
}
