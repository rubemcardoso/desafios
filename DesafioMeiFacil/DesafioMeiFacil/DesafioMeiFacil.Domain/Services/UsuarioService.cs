using System.Collections.Generic;
using System.Linq;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Repositories;
using DesafioMeiFacil.Domain.Interfaces.Services;

namespace DesafioMeiFacil.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> ObterUsuariosEspeciais(IEnumerable<Usuario> usuarios)
        {
            return usuarios.Where(c => c.UsuarioEspecial(c));
        }

        public Usuario BuscarPeloEmail(string email)
        {
            return _usuarioRepository.BuscarPeloEmail(email);
        }
    }
}
