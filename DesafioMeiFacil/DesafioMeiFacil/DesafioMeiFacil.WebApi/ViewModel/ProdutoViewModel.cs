using System.ComponentModel.DataAnnotations;

namespace DesafioMeiFacil.WebApi.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public long ProdutoKey { get; set; }

        [MaxLength(2000, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, 9999999999999999.99, ErrorMessage = "Preço inválido; Máximo de 18 dígitos")]
        public decimal? Preco { get; set; }

        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Categoria { get; set; }

        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Regiao { get; set; }

        public string Url { get; set; }
    }
}