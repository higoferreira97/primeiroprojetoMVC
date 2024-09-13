using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Matricula).HasColumnType("varchar(30)");
            builder.Property(t => t.Nome).HasColumnType("varchar(40)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(14)");
            builder.Property(t => t.DataDeNascimento).HasColumnType("DateOnly");
            builder.Property(t => t.Endereco).HasColumnType("varchar(50)");

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
