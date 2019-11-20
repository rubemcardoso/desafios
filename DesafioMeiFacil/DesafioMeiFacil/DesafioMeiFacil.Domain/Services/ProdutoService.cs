using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Repositories;
using DesafioMeiFacil.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DesafioMeiFacil.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao)
        {
            return _produtoRepository.BuscarPorParametros(titulo, regiao);
        }
    }
}
