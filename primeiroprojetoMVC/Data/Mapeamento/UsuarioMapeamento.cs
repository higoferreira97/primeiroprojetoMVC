using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //builder.ToTable("Usuario");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Email).HasColumnType("varchar(100)");
            builder.Property(t => t.Senha).HasColumnType("varchar(40)");
           
           
        }
    }
}


//create table aluno(
//id int identity(1,1) not null,
//matricula varchar(30),
//nome varchar(40),
//cpf varchar(14),
//datadenascimento date,
//endereco varchar(50)
//primary key(id)
//)
