using DesafioMeiFacil.Domain.ContractEntity.Usuario;
using System;

namespace DesafioMeiFacil.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public PerfilUsuarioEnum Perfil { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public bool UsuarioEspecial(Usuario usuario)
        {
            return usuario.Ativo && DateTime.Now.Year - usuario.DataCadastro.Year >= 5;
        }
    }
}
