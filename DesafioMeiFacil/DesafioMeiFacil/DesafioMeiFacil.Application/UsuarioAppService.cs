using DesafioMeiFacil.Application.Interface;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DesafioMeiFacil.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IEnumerable<Usuario> ObterUsuariosEspeciais()
        {
            return _usuarioService.ObterUsuariosEspeciais(_usuarioService.GetAll());
        }

        public Usuario BuscarPeloEmail(string email)
        {
            return _usuarioService.BuscarPeloEmail(email);
        }
    }
}
