using DesafioMeiFacil.Application.Interface;
using DesafioMeiFacil.CrossCutting.Util;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioMeiFacil.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao)
        {
            return _produtoService.BuscarPorParametros(titulo, regiao);
        }

        public void ScrapProdutos(string nome, string regiao)
        {
            var produtos = new List<Produto>();

            var result = Task.Run(async () => await ProdutoScrapService.GetHtmlAsync(nome, regiao, produtos)).ConfigureAwait(false);

            result.GetAwaiter().GetResult();

            _produtoService.AddRange(produtos);
        }
    }
}
