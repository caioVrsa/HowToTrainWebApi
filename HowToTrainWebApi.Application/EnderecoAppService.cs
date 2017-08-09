using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService)
            : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }
    }
}
