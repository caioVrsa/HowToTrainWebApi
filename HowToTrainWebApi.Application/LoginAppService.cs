using HowToTrainWebApi.Application.Interface;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Application
{
    public class LoginAppService : AppServiceBase<Login>, ILoginAppService
    {
        private readonly ILoginService _loginService;

        public LoginAppService(ILoginService loginService)
            : base(loginService)
        {
            _loginService = loginService;
        }
    }
}
