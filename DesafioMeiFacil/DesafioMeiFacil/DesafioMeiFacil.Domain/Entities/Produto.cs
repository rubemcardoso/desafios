namespace DesafioMeiFacil.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public long ProdutoKey { get; set; }

        public string Titulo { get; set; }

        public decimal? Preco { get; set; }

        public string Categoria { get; set; }

        public string Regiao { get; set; }

        public string Url { get; set; }
    }
}
