using System.Collections.Generic;
using System.Linq;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.Domain.Interfaces.Repositories;

namespace DesafioMeiFacil.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorParametros(string titulo, string regiao)
        {
            var produtos = Db.Produtos;

            if (!string.IsNullOrEmpty(titulo))
                produtos.Where(p => p.Titulo == titulo);

            if (!string.IsNullOrEmpty(titulo))
                produtos.Where(p => p.Regiao == regiao);

            return produtos.ToList();
        }
    }
}
