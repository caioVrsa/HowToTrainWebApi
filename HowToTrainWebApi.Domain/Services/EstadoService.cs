using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Domain.Services
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
            : base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
    }
}
