using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;
using HowToTrainWebApi.Domain.Interfaces.Services;

namespace HowToTrainWebApi.Domain.Services
{
    public class LoginService : ServiceBase<Login>, ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
            : base(loginRepository)
        {
            _loginRepository = loginRepository;
        }
    }
}
