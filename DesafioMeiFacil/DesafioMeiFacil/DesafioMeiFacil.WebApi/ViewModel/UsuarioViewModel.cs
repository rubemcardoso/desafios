using DesafioMeiFacil.Domain.ContractEntity.Usuario;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesafioMeiFacil.WebApi.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(255, ErrorMessage = "Máximo {0} caracteres")]
        [PasswordPropertyText]
        [DisplayName("Senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Selecione o campo Perfil")]
        [Range(-2, -1, ErrorMessage = "É necessário selecionar um Perfil")]
        [DisplayName("Perfil")]
        public PerfilUsuarioEnum Perfil { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}