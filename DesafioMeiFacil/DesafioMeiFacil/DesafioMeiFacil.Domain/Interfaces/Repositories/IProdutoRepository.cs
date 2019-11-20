using DesafioMeiFacil.Domain.Entities;
using System.Collections.Generic;

namespace DesafioMeiFacil.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao);
    }
}
