﻿using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.Domain.Interfaces;
using HowToTrainWebApi.Domain.Interfaces.Repositories;

namespace HowToTrainWebApi.Infra.Data.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
    }
}
