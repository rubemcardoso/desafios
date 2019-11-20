using AutoMapper;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.WebApi.ViewModels;

namespace DesafioMeiFacil.WebApi.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}