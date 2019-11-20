using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using DesafioMeiFacil.Application.Interface;
using DesafioMeiFacil.Domain.Entities;
using DesafioMeiFacil.WebApi.ViewModels;

namespace DesafioMeiFacil.WebApi.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly IProdutoAppService _produtoApp;

        public ProdutosController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        // GET: api/Produtos
        public List<ProdutoViewModel> GetProdutoViewModels()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return produtoViewModel.ToList();
        }

        // GET: api/Produtos/5
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult GetProdutoViewModel(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            if (produtoViewModel == null)
                return NotFound();

            return Ok(produtoViewModel);
        }

        // PUT: api/Produtos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProdutoViewModel(int id, ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produtoViewModel.Id) return BadRequest();

            var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);

            try
            {
                _produtoApp.Update(produtoDomain);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoViewModelExists(id)) return NotFound();
                else throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Produtos
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult PostProdutoViewModel(ProdutoViewModel produtoViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produtoViewModel);
            _produtoApp.Add(produtoDomain);

            return CreatedAtRoute("DefaultApi", new { id = produtoViewModel.Id }, produtoViewModel);
        }

        // DELETE: api/Produtos/5
        [ResponseType(typeof(ProdutoViewModel))]
        public IHttpActionResult DeleteProdutoViewModel(int id)
        {
            var produto = _produtoApp.GetById(id);
            
            if (produto == null) return NotFound();

            _produtoApp.Remove(produto);

            return Ok(produto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _produtoApp.Dispose();
            base.Dispose(disposing);
        }

        private bool ProdutoViewModelExists(int id)
        {
            return _produtoApp.GetById(id) != null;
        }

        [Route("api/produtos/scrap")]
        [HttpGet]
        public void Scrap()
        {
            _produtoApp.ScrapProdutos();
        }

        [Route("api/produtos/scrap")]
        [HttpGet]
        public void Scrap(string nome, string regiao)
        {
            _produtoApp.ScrapProdutos(nome, regiao);
        }
    }
}