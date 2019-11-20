using DesafioMeiFacil.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DesafioMeiFacil.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.ProdutoKey)
                .IsRequired();

            Property(p => p.Titulo)
                .IsOptional()
                .HasMaxLength(2000);

            Property(p => p.Preco)
                .IsOptional();

            Property(p => p.Categoria)
                .IsOptional()
                .HasMaxLength(500);

            Property(p => p.Regiao)
                .IsOptional()
                .HasMaxLength(500);

            Property(p => p.Url)
                .IsOptional()
                .HasColumnType("nvarchar(max)")
                .HasMaxLength(null);
        }
    }
}
