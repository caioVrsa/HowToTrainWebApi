using AutoMapper;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.WebService.ViewModels;

namespace HowToTrainWebApi.WebService.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToDomainMappingProfile";

        public DomainToViewModelMappingProfile()
        {
            CreateMap<PaisViewModel, Pais>();
        }
    }
}