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


//CREATE TABLE Aluno(
//Id int identity(1,1) NOT NULL,
//Matricula VARCHAR(30),
//Nome VARCHAR(40),
//Cpf VARCHAR(14),
//DataDeNascimento DATE,
//Endereco VARCHAR(50)
//PRIMARY KEY(Id)
//)
