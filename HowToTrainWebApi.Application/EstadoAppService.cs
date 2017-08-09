using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class EstadoAppService : AppServiceBase<Estado>, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;

        public EstadoAppService(IEstadoService estadoService)
            : base(estadoService)
        {
            _estadoService = estadoService;
        }
    }
}
