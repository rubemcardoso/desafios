using DesafioMeiFacil.Domain.Entities;
using System.Collections.Generic;

namespace DesafioMeiFacil.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao);
    }
}
