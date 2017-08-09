using AutoMapper;
using HowToTrainWebApi.Domain.Entities;
using HowToTrainWebApi.WebService.ViewModels;

namespace HowToTrainWebApi.WebService.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappingProfile";

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Pais, PaisViewModel>();
        }
    }
}