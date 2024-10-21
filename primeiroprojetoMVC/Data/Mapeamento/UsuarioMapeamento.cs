using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Email).HasColumnType("varchar(100)");
            builder.Property(t => t.Senha).HasColumnType("varchar(40)");
           
           
        }
    }
}



