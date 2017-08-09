using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Domain.Services
{
    public class PaisService : ServiceBase<Pais>, IPaisService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository paisRepository)
            : base(paisRepository)
        {
            _paisRepository = paisRepository;
        }
    }
}
