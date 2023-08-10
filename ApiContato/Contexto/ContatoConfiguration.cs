using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiContato.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiContato.Contexto
{
    public class ContatoConfiguration: IEntityTypeConfiguration<Contato>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Contato> builder)
        {
            builder.HasData(
               new Contato { Id = 1, PessoaId = 1, Type = "Email", Value = "ramonss.bque@gmail.com" },
               new Contato { Id = 2, PessoaId = 1, Type = "Telefone", Value = "64987658798" }
            );
        }
    }
}