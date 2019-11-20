using DesafioMeiFacil.Domain.Entities;
using System.Collections.Generic;

namespace DesafioMeiFacil.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> ObterUsuariosEspeciais(IEnumerable<Usuario> usuarios);

        Usuario BuscarPeloEmail(string email);
    }
}
