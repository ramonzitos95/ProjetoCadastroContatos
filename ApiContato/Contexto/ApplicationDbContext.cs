using ApiContato.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiContato.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
            .HasMany(x => x.Contatos)
            .WithOne()
            .HasForeignKey(x => x.PessoaId);

            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());

        }

        public DbSet<Pessoa> People { get; set; }
        public DbSet<Contato> Contacts { get; set; }
    }
}
