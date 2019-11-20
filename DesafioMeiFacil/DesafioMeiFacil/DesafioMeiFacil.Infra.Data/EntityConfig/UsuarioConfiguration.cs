using DesafioMeiFacil.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DesafioMeiFacil.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(255); ;

            Property(c => c.Senha)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Perfil)
                .IsRequired();
        }
    }
}
