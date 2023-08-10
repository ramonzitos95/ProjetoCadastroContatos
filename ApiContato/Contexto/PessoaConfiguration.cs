using ApiContato.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiContato.Contexto
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasData(
                new Pessoa
                {
                    Id = 1,
                    Idade = 28,
                    Nome = "Ramon"
                }
            );
        }
    }
}
