using DesafioMeiFacil.Domain.Entities;
using System.Collections.Generic;

namespace DesafioMeiFacil.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        IEnumerable<Usuario> ObterUsuariosEspeciais();

        Usuario BuscarPeloEmail(string email);
    }
}
