using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Repositories;
using System.Linq;

namespace DesafioMeiFacil.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public Usuario BuscarPeloEmail(string email)
        {
            return Db.Usuarios.Where(u => u.Email.Equals(email)).FirstOrDefault();
        }
    }
}
