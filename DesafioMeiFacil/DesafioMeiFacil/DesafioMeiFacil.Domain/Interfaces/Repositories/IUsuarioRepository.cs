using DesafioMeiFacil.Domain.Entities;

namespace DesafioMeiFacil.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario BuscarPeloEmail(string email);
    }
}
