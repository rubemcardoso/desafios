using AutoMapper;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.WebApi.ViewModels;

namespace DesafioMeiFacil.WebApi.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}