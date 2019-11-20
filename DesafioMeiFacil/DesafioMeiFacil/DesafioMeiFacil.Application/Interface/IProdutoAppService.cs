using DesafioMeiFacil.Domain.Entities;
using System.Collections.Generic;

namespace DesafioMeiFacil.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao);

        void ScrapProdutos(string nome = "", string regiao = "");
    }
}
