using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces.Repositories;

namespace HowToTrainWebApi.Infra.Data.Repositories
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
    }
}
